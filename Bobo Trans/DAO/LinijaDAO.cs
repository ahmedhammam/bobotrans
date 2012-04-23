using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;

using DAL.Interfejsi;
using DAL.Entiteti;

namespace DAL
{
    partial class DAL
    {
        public class LinijaDAO:IDaoCrud<Linija>
        {

            protected MySqlCommand c;

            public long create(Linija entity)
            {
                long idLinije;

                //unosenje u tabelu linije
                try
                {
                    c = new MySqlCommand(String.Format("INSERT INTO linije VALUES ('','{0}');", entity.NazivLinije), con);
                    c.ExecuteNonQuery();
                    idLinije = c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }


                //unosenje u tabelu staniceuliniji
                int brojac = 0;

                try
                {
                    if (entity.Stanice.Count < 2) throw new Exception("Nedovoljno stanica u liniji");
                    for (brojac = 0; brojac < entity.Stanice.Count; brojac++)
                    {
                        c = new MySqlCommand(String.Format("INSERT INTO staniceuliniji VALUES ('','{0}','{1}','{2}','{3}')",
                            idLinije, entity.Stanice[brojac].SifraStanice, entity.TrajanjeDoDolaska[brojac], entity.TrajanjeDoPolaska[brojac]), con);
                        c.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    //dodati kod !
                    throw e;
                }

                //unosenje voznji u voznje i linijevoznje
                try
                {
                    if (entity.Voznje.Count < 1) throw new Exception("Nedovoljno voznji u liniji");
                    for (brojac = 0; brojac < entity.Voznje.Count; brojac++)
                    {
                        entity.Voznje[brojac].SifraVoznje= DAOFactory.Instanca.getVoznjaDAO().create(entity.Voznje[brojac]);
                        c = new MySqlCommand(string.Format("INSERT INTO linijevoznje VALUES ('','{0}','{1}');", entity.SifraLinije,entity.Voznje[brojac].SifraVoznje), con);
                        c.ExecuteNonQuery();
                    }
                }

                catch (Exception e)
                {
                    brisiVoznjeDo(entity, brojac);
                    throw e;
                }
                //unosenje rasporeda voznje
                brojac = 0;
                try
                {
                    if (entity.RasporediVoznje.Count < 1) throw new Exception("Nedovoljno rasporeda voznje!");
                    for(brojac=0;brojac<entity.RasporediVoznje.Count;brojac++)
                    {
                        entity.RasporediVoznje[brojac].SifraRasporedaVoznji=DAOFactory.Instanca.getRasporedVoznjiDAO().create(entity.RasporediVoznje[brojac]);
                        c = new MySqlCommand(string.Format("INSERT INTO linijerasporedvoznji VALUES ('','{0}','{1}');", 
                            entity.SifraLinije, entity.RasporediVoznje[brojac].SifraRasporedaVoznji), con);
                        c.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    brisiVoznjeDo(entity, entity.Voznje.Count);
                    brisiRasporedeVoznjeDo(entity, brojac);
                    throw e;
                }

                //unosenje cijena
                int brojac2;
                try
                {
                    if (entity.Cijene.Count != entity.Stanice.Count) throw new Exception("Nedovoljno unesenih cijena!");
                    for(brojac=0; brojac<entity.Cijene.Count;brojac++)
                    {
                        for(brojac2=0;brojac2<entity.Cijene[brojac].Count;brojac2++)
                        {
                            c = new MySqlCommand(string.Format("INSERT INTO linijecijene VALUES ('','{0}','{1}','{2}','{3}');",
                                entity.SifraLinije,entity.Stanice[brojac].SifraStanice,entity.Stanice[brojac2].SifraStanice,entity.Cijene[brojac][brojac2]),con);
                            c.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                return idLinije;
            }

            private void brisiRasporedeVoznjeDo(Linija l, int indeks)
            {
                for (int i = 0; i < indeks; i++)
                {
                    DAOFactory.Instanca.getRasporedVoznjiDAO().delete(l.RasporediVoznje[i]);
                }
            }

            private void brisiVoznjeDo(Linija l,int indeks)
            {
                for (int i = 0; i < indeks; i++)
                {
                    DAOFactory.Instanca.getVoznjaDAO().delete(l.Voznje[i]);
                }
            }

            public Linija read(Linija entity)
            {
                long sifra;
                string naziv;
                List<Stanica> stanice = new List<Stanica>();
                List<int> trajanjeDoDolaska = new List<int>();
                List<int> trajanjeDoPolaska = new List<int>();
                List<Voznja> voznje = new List<Voznja>();
                List<RasporedVoznje> rasporediVoznje = new List<RasporedVoznje>();
                List<List<double>> cijene;

                //ucitavanje imena i sifre iz tabele linije
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM linije WHERE naziv='{0}'", entity.NazivLinije), con);

                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        sifra = r.GetInt32("id");
                        naziv = r.GetString("naziv");
                    }
                    else throw
                     new Exception("nije nadjen nijedan element");
                    r.Close();

                //ucitavanje stanica, trajanjaDO, trajanjaOD iz tabele staniceuliniji sortirane po vremenu trajanjaDoDolaska
                    c = new MySqlCommand(String.Format("SELECT sul.*,s.naziv,s.mjesto FROM (SELECT * FROM staniceuliniji WHERE idLinije='{0}') AS sul LEFT JOIN stanice AS s ON s.id = sul.idStanice ORDER BY sul.trajanjeDoDolaska;", 
                        sifra), con);

                    r = c.ExecuteReader();
                    while(r.Read())
                    {
                        stanice.Add(new Stanica(r.GetInt32("idStanice"),r.GetString("naziv"),r.GetString("mjesto")));
                        trajanjeDoDolaska.Add(r.GetInt32("trajanjeDoDolaska"));
                        trajanjeDoPolaska.Add(r.GetInt32("trajanjeDoPolaska"));
                    }
                    r.Close();
                //ucitavanje voznji

                    c = new MySqlCommand(String.Format("SELECT * FROM linijevoznje WHERE idLinije='{0}';", sifra), con);
                    long sifraVoznje;
                    r = c.ExecuteReader();
                    while (r.Read())
                    {
                        sifraVoznje = r.GetInt32("idVoznje");
                        voznje.Add(DAOFactory.Instanca.getVoznjaDAO().getById(sifraVoznje));
                    }

                    r.Close();

                //ucitavanje rasporeda voznji
                    c = new MySqlCommand(String.Format("SELECT * FROM linijerasporedvoznji WHERE idLinije='{0}';", sifra), con);
                    r = c.ExecuteReader();
                    long sifraRasporedaVoznje;
                    while (r.Read())
                    {
                        sifraRasporedaVoznje = r.GetInt32("idRasporedaVoznje");
                        rasporediVoznje.Add(DAOFactory.Instanca.getRasporedVoznjiDAO().getById(sifraRasporedaVoznje));
                    }
                    r.Close();

                 // ucitavanje cijena

                    cijene = new List<List<double>>(stanice.Count);

                    for (int i = 0; i < stanice.Count; i++)
                    {
                        cijene[i] = new List<double>(stanice.Count);
                        for (int j = 0; j < i; j++)
                            cijene[i][j] = cijene[j][i];

                        cijene[i][i] = 0;
                        for (int j = i+1; j < stanice.Count; j++)
                        {
                            c = new MySqlCommand(string.Format("SELECT cijena FROM linijecijene WHERE idLinije='{0} AND idPrveStanice = '{1}' AND idDrugeStanice='{2}';",
                                sifra,stanice[i].SifraStanice,stanice[j].SifraStanice),con);
                            r = c.ExecuteReader();
                            if (!r.Read()) 
                                throw new Exception("Ne postoji cijena za liniju " + sifra.ToString() + " i stanice "+stanice[j].SifraStanice.ToString() + " i " +stanice[j].SifraStanice.ToString());
                            
                            cijene[i][j] = r.GetDouble("cijena");
                            r.Close();
                        }

                    }
                }
                catch (Exception e)
                {
                    throw e;
                }

                return new Linija(sifra,naziv,stanice,trajanjeDoDolaska, trajanjeDoPolaska,cijene,voznje,rasporediVoznje);
            }

            public Linija update(Linija entity)
            {

                delete(entity);
                entity.SifraLinije = create(entity);
                #region komplikovanijiNacin-Nedovrsen
                /*for (int i = 0; i < entity.Stanice.Count; i++)
                    {
                        int tmpIndeksI=-1,tmpIndeksJ=-1;

                        for (int j = 0; j < l.Stanice.Count; j++)
                        {
                            if (entity.Stanice[i].SifraStanice == l.Stanice[j].SifraStanice)
                            {
                                tmpIndeksI=i;
                                tmpIndeksJ=j;
                                break;
                            }
                        }

                        if (tmpIndeksI < 0)
                        {
                            c = new MySqlCommand(string.Format("INSERT INTO staniceuliniji VALUES ('','{0}','{1}','{2}','{3}');",
                                entity.SifraLinije, entity.Stanice[tmpIndeksI].SifraStanice, entity.TrajanjeDoDolaska[tmpIndeksI], entity.TrajanjeDoPolaska[tmpIndeksI]), con);
                        }
                        else
                        {
                            if(entity.TrajanjeDoPolaska[tmpIndeksI]!=l.TrajanjeDoPolaska[tmpIndeksJ] || entity.TrajanjeDoDolaska[tmpIndeksI]!=l.TrajanjeDoDolaska[tmpIndeksJ])
                            {
                                c = new MySqlCommand(string.Format("UPDATE staniceuliniji SET  WHERE');",
                               entity.SifraLinije, entity.Stanice[tmpIndeksI].SifraStanice, entity.TrajanjeDoDolaska[tmpIndeksI], entity.TrajanjeDoPolaska[tmpIndeksI]), con);
                            }
                        }
                    }*/

                #endregion
                return entity;
            }

            public void delete(Linija entity)
            {
                try
                {
                    c = new MySqlCommand(string.Format("DELETE * FROM linije WHERE id='{0}'", entity.SifraLinije), con);
                    c.ExecuteNonQuery();

                    c = new MySqlCommand(string.Format("DELETE * FROM linijevoznje WHERE idLinije='{0}'", entity.SifraLinije), con);
                    c.ExecuteNonQuery();

                    c = new MySqlCommand(string.Format("DELETE * FROM linijerasporedvoznji WHERE idLinije='{0}'", entity.SifraLinije), con);
                    c.ExecuteNonQuery();

                    c = new MySqlCommand(string.Format("DELETE * FROM staniceuliniji WHERE idLinije='{0}'", entity.SifraLinije), con);
                    c.ExecuteNonQuery();

                    c = new MySqlCommand(string.Format("DELETE * FROM linijecijene WHERE idLinije='{0}'", entity.SifraLinije), con);
                    c.ExecuteNonQuery();

                    foreach (Voznja v in entity.Voznje)
                    {
                        DAOFactory.Instanca.getVoznjaDAO().delete(v);
                    }

                    foreach (RasporedVoznje rv in entity.RasporediVoznje)
                    {
                        DAOFactory.Instanca.getRasporedVoznjiDAO().delete(rv);
                    }

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Linija getById(long id)
            {
                string naziv;
                List<Stanica> stanice = new List<Stanica>();
                List<int> trajanjeDoDolaska = new List<int>();
                List<int> trajanjeDoPolaska = new List<int>();
                List<Voznja> voznje = new List<Voznja>();
                List<RasporedVoznje> rasporediVoznje = new List<RasporedVoznje>();
                List<List<double>> cijene;

                //ucitavanje imena i sifre iz tabele linije
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM linije WHERE id='{0}'", id), con);

                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        naziv = r.GetString("naziv");
                    }
                    else throw
                     new Exception("nije nadjen nijedan element");
                    r.Close();
                //ucitavanje stanica, trajanjaDO, trajanjaOD iz tabele staniceuliniji sortirane po vremenu trajanjaDoDolaska
                    c = new MySqlCommand(String.Format("SELECT sul.*,s.naziv,s.mjesto FROM (SELECT * FROM staniceuliniji WHERE idLinije='{0}') AS sul LEFT JOIN stanice AS s ON s.id = sul.idStanice ORDER BY sul.trajanjeDoDolaska;", 
                        id), con);

                    r = c.ExecuteReader();
                    while(r.Read())
                    {
                        stanice.Add(new Stanica(r.GetInt32("idStanice"),r.GetString("naziv"),r.GetString("mjesto")));
                        trajanjeDoDolaska.Add(r.GetInt32("trajanjeDoDolaska"));
                        trajanjeDoPolaska.Add(r.GetInt32("trajanjeDoPolaska"));
                    }
                    r.Close();
                //ucitavanje voznji

                    c = new MySqlCommand(String.Format("SELECT * FROM linijevoznje WHERE idLinije='{0}';", id), con);
                    long sifraVoznje;
                    r = c.ExecuteReader();
                    while (r.Read())
                    {
                        sifraVoznje = r.GetInt32("idVoznje");
                        voznje.Add(DAOFactory.Instanca.getVoznjaDAO().getById(sifraVoznje));
                    }
                    r.Close();

                //ucitavanje rasporeda voznji
                    c = new MySqlCommand(String.Format("SELECT * FROM linijerasporedvoznji WHERE idLinije='{0}';", id), con);
                    r = c.ExecuteReader();
                    long sifraRasporedaVoznje;
                    while (r.Read())
                    {
                        sifraRasporedaVoznje = r.GetInt32("idRasporedaVoznje");
                        rasporediVoznje.Add(DAOFactory.Instanca.getRasporedVoznjiDAO().getById(sifraRasporedaVoznje));
                    }
                    r.Close();
                 // ucitavanje cijena

                    cijene = new List<List<double>>(stanice.Count);

                    for (int i = 0; i < stanice.Count; i++)
                    {
                        cijene[i] = new List<double>(stanice.Count);
                        for (int j = 0; j < i; j++)
                            cijene[i][j] = cijene[j][i];

                        cijene[i][i] = 0;
                        for (int j = i+1; j < stanice.Count; j++)
                        {
                            c = new MySqlCommand(string.Format("SELECT cijena FROM linijecijene WHERE idLinije='{0} AND idPrveStanice = '{1}' AND idDrugeStanice='{2}';",
                                id,stanice[i].SifraStanice,stanice[j].SifraStanice),con);
                            r = c.ExecuteReader();
                            if (!r.Read()) 
                                throw new Exception("Ne postoji cijena za liniju " + id.ToString() + " i stanice "+stanice[j].SifraStanice.ToString() + " i " +stanice[j].SifraStanice.ToString());
                            cijene[i][j] = r.GetDouble("cijena");
                            r.Close();
                        }

                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                return new Linija(id,naziv,stanice,trajanjeDoDolaska, trajanjeDoPolaska,cijene,voznje,rasporediVoznje);
            }

            public List<Linija> GetAll()
            {
                List<Linija> linije = new List<Linija>();

                c = new MySqlCommand("SELECT id FROM linije",con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                {
                    linije.Add(getById(r.GetInt32("id")));
                }
                r.Close();
                return linije;
            }

            public List<Linija> getByExample(string name, string values)
            {
                throw new Exception("get by Example se ne moze implementirati za linije");
            }
        }
    }
}

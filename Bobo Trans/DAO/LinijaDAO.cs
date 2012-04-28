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

            #region funkcije za unos linije u bazu
            public long create(Linija entity)
            {
                if (entity.TrajanjeDoDolaska.Count != entity.Stanice.Count || entity.TrajanjeDoPolaska.Count != entity.Stanice.Count)
                    throw new Exception("Neispravan ulazni oblik za unos u bazu!");

                c = new MySqlCommand("START TRANSACTION;",con);
                try
                {
                    c.ExecuteNonQuery();
                    long idLinije = unesiLinije(ref entity);
                    unesiStaniceULiniji(ref entity, idLinije);
                    unesiVoznje(ref entity, idLinije);
                    unesiRasporedeVoznje(ref entity, idLinije);
                    unesiCijene(ref entity, idLinije);
                    c = new MySqlCommand("COMMIT;", con);
                    c.ExecuteNonQuery();
                    return idLinije;
                }
                catch(Exception e)
                {
                    c = new MySqlCommand("ROLLBACK;",con);
                    c.ExecuteNonQuery();
                    throw e;
                }
            }

            private void unesiCijene(ref Linija entity, long idLinije)
            {
                if (entity.Cijene.Count != entity.Stanice.Count-1) throw new Exception("Nedovoljno unesenih cijena!");
                for (int i = 0; i < entity.Cijene.Count; i++)
                {
                    for (int j = 0; j < entity.Cijene[i].Count; j++)
                    {
                        c = new MySqlCommand(string.Format("INSERT INTO linijecijene VALUES ('','{0}','{1}','{2}','{3}');",
                            idLinije, entity.Stanice[i].SifraStanice, entity.Stanice[i+j+1].SifraStanice, entity.Cijene[i][j].ToString().Replace(',','.')), con);
                        c.ExecuteNonQuery();

                    }
                }
            }

            private void unesiRasporedeVoznje(ref Linija entity, long idLinije)
            {
                if (entity.RasporediVoznje.Count < 1) throw new Exception("Nedovoljno rasporeda voznje!");
                for (int i = 0; i < entity.RasporediVoznje.Count; i++)
                {
                    entity.RasporediVoznje[i].SifraRasporedaVoznji = DAOFactory.Instanca.getRasporedVoznjiDAO().create(entity.RasporediVoznje[i]);
                    c = new MySqlCommand(string.Format("INSERT INTO linijerasporedvoznji VALUES ('','{0}','{1}');",
                        idLinije, entity.RasporediVoznje[i].SifraRasporedaVoznji), con);
                    c.ExecuteNonQuery();
                }
            }

            private void unesiVoznje(ref Linija entity, long idLinije)
            {
                if (entity.Voznje.Count < 1) throw new Exception("Nedovoljno voznji u liniji");
                for (int i = 0; i < entity.Voznje.Count; i++)
                {
                    entity.Voznje[i].SifraVoznje = DAOFactory.Instanca.getVoznjaDAO().create(entity.Voznje[i]);
                    c = new MySqlCommand(string.Format("INSERT INTO linijevoznje VALUES ('','{0}','{1}');", idLinije, entity.Voznje[i].SifraVoznje), con);
                    c.ExecuteNonQuery();
                }
            }

            private long unesiLinije(ref Linija entity)
            {
                c = new MySqlCommand(String.Format("INSERT INTO linije VALUES ('','{0}');", entity.NazivLinije), con);
                c.ExecuteNonQuery();
                return c.LastInsertedId;
            }

            private void unesiStaniceULiniji(ref Linija entity, long idLinije)
            {
                if (entity.Stanice.Count < 1) throw new Exception("Nedovoljno stanica u liniji");
                for (int i = 0; i < entity.Stanice.Count; i++)
                {
                    c = new MySqlCommand(String.Format("INSERT INTO staniceuliniji VALUES ('','{0}','{1}','{2}','{3}')",
                        idLinije, entity.Stanice[i].SifraStanice, entity.TrajanjeDoDolaska[i], entity.TrajanjeDoPolaska[i]), con);
                    c.ExecuteNonQuery();
                }
            } 
            #endregion

            public Linija read(Linija entity)
            {
                return getById(ucitajSifru(entity.NazivLinije));
            }

            public Linija update(Linija entity)
            {
                delete(entity);
                entity.SifraLinije = create(entity);
                return entity;
            }

            public void delete(Linija entity)
            {
                try
                {
                    c = new MySqlCommand("START TRANSACTION;", con);
                    c.ExecuteNonQuery();
                    foreach (Voznja v in entity.Voznje)
                        DAOFactory.Instanca.getVoznjaDAO().delete(v);

                    foreach (RasporedVoznje rv in entity.RasporediVoznje)
                        DAOFactory.Instanca.getRasporedVoznjiDAO().delete(rv);

                    c = new MySqlCommand(string.Format("DELETE FROM staniceuliniji WHERE idLinije='{0}'", entity.SifraLinije), con);
                    c.ExecuteNonQuery();

                    c = new MySqlCommand(string.Format("DELETE FROM linijecijene WHERE idLinije='{0}'", entity.SifraLinije), con);
                    c.ExecuteNonQuery();

                    c = new MySqlCommand(string.Format("DELETE FROM linije WHERE id='{0}'", entity.SifraLinije), con);
                    c.ExecuteNonQuery();

                    c = new MySqlCommand("COMMIT;", con);
                    c.ExecuteNonQuery();
                    Console.WriteLine("AAAA");
                }
                catch (Exception e)
                {
                    c = new MySqlCommand("ROLLBACK;", con);
                    c.ExecuteNonQuery();
                    throw e;
                }
            }

            public Linija getById(long id)

            {
                long sifra = id;
                string naziv;
                List<Stanica> stanice = new List<Stanica>();
                List<int> trajanjeDoDolaska = new List<int>();
                List<int> trajanjeDoPolaska = new List<int>();
                List<Voznja> voznje = new List<Voznja>();
                List<RasporedVoznje> rasporediVoznje = new List<RasporedVoznje>();
                List<List<double>> cijene;

                try
                {
                    c = new MySqlCommand("START TRANSACTION;", con);
                    c.ExecuteNonQuery();
                    naziv = ucitajNaziv(id);
                    ucitavanjeIzStaniceULiniji(sifra, ref stanice, ref trajanjeDoDolaska, ref trajanjeDoPolaska);
                    ucitajVoznje(sifra, ref voznje);
                    ucitajRasporedVoznji(sifra, ref rasporediVoznje);
                    cijene = new List<List<double>>();

                    for (int i = 0; i < stanice.Count - 1; i++)
                    {
                        cijene.Add(new List<double>());
                        for (int j = 0; j < stanice.Count  - i - 1; j++)
                            cijene[i].Add(0);
                    }
                    ucitajCijene(sifra, stanice.Count, ref cijene);
                    c = new MySqlCommand("COMMIT;", con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    c = new MySqlCommand("ROLLBACK;", con);
                    c.ExecuteNonQuery();
                    throw e;
                }

                return new Linija(sifra, naziv, stanice, trajanjeDoDolaska, trajanjeDoPolaska, cijene, voznje, rasporediVoznje);
            }

            #region funkcije za ucitavanje
            private void ucitajCijene(long sifraLinije, int brStanica, ref List<List<double>> cijene)
            {
                c = new MySqlCommand(string.Format("SELECT lc.*, sul.trajanjeDoDolaska FROM (SELECT * FROM linijecijene WHERE idLinije='{0}') AS lc LEFT JOIN staniceuliniji AS sul ON sul.idLinije='{0}' AND sul.idStanice = lc.idPrveStanice ORDER BY sul.trajanjeDoDolaska,lc.cijena;",
                    sifraLinije), con);
                MySqlDataReader r = c.ExecuteReader();

                int sifra1, sifra2;
                for (int i = 0; i < brStanica-1; i++)
                {
                    for (int j = 0; j < brStanica - i - 1; j++)
                    {
                        r.Read();
                        sifra1 = r.GetInt16("idPrveStanice");
                        sifra2 = r.GetInt16("idDrugeStanice");   
                        cijene[i][j] = r.GetDouble("cijena");
                    }
                }
                r.Close();
            }

            private void ucitajRasporedVoznji(long sifra, ref List<RasporedVoznje> rasporediVoznje)
            {
                rasporediVoznje = new List<RasporedVoznje>();
                c = new MySqlCommand(String.Format("SELECT * FROM linijerasporedvoznji WHERE idLinije='{0}';", sifra), con);
                MySqlDataReader r = c.ExecuteReader();
                List<long> sifraRasporedaVoznje = new List<long>();
                while (r.Read())
                    sifraRasporedaVoznje.Add(r.GetInt32("idRasporedaVoznje"));
                r.Close();
                foreach (long sifraR in sifraRasporedaVoznje)
                {
                    rasporediVoznje.Add(DAOFactory.Instanca.getRasporedVoznjiDAO().getById(sifraR));
                }
            }

            private void ucitajVoznje(long sifra, ref List<Voznja> voznje)
            {
                voznje = new List<Voznja>();
                c = new MySqlCommand(String.Format("SELECT idVoznje FROM linijevoznje WHERE idLinije='{0}';", sifra), con);
                List<long> sifraVoznje = new List<long>();
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                    sifraVoznje.Add(r.GetInt32("idVoznje"));
                r.Close();
                foreach(long sifraV in sifraVoznje)
                    voznje.Add(DAOFactory.Instanca.getVoznjaDAO().getById(sifraV));

                r.Close();
            }

            private void ucitavanjeIzStaniceULiniji(long sifra, ref List<Stanica> stanice, ref List<int> trajanjeDoDolaska, ref List<int> trajanjeDoPolaska)
            {
                stanice = new List<Stanica>();
                trajanjeDoDolaska = new List<int>();
                trajanjeDoPolaska = new List<int>();

                c = new MySqlCommand(String.Format("SELECT sul.*,s.naziv,s.mjesto FROM (SELECT * FROM staniceuliniji WHERE idLinije='{0}') AS sul LEFT JOIN stanice AS s ON s.id = sul.idStanice ORDER BY sul.trajanjeDoDolaska;",
                        sifra), con);

                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                {
                    stanice.Add(new Stanica(r.GetInt32("idStanice"), r.GetString("naziv"), r.GetString("mjesto")));
                    trajanjeDoDolaska.Add(r.GetInt32("trajanjeDoDolaska"));
                    trajanjeDoPolaska.Add(r.GetInt32("trajanjeDoPolaska"));
                }
                r.Close();
            }

            private long ucitajSifru(string naziv)
            {
                c = new MySqlCommand(String.Format("SELECT * FROM linije WHERE naziv='{0}'", naziv), con);
                long sifra;
                MySqlDataReader r = c.ExecuteReader();
                if (r.Read())
                {
                    sifra = r.GetInt32("id");
                    r.Close();
                    return sifra;
                }
                else throw
                 new Exception("nije nadjen nijedan element");
            } 
            
            private string ucitajNaziv(long sifraLinije)
            {
                c = new MySqlCommand(String.Format("SELECT * FROM linije WHERE id='{0}'", sifraLinije), con);
                MySqlDataReader r = c.ExecuteReader();
                if (r.Read())
                {
                    string naziv = r.GetString("naziv");
                    r.Close();
                    return naziv;
                }
                else throw
                 new Exception("nije nadjen nijedan element");
            }

            #endregion
            public List<Linija> GetAll()
            {
                List<Linija> linije = new List<Linija>();
                c = new MySqlCommand("SELECT id FROM linije",con);
                MySqlDataReader r = c.ExecuteReader();
                List<long> sifre = new List<long>();
                while (r.Read())
                    sifre.Add(r.GetInt32("id"));
                r.Close();

                foreach(long sifra in sifre)
                   linije.Add(getById(sifra));
                return linije;
            }

            public List<Linija> getByExample(string name, string values)
            {
                throw new Exception("get by Example se ne moze implementirati za linije");
            }

        }
    }
}

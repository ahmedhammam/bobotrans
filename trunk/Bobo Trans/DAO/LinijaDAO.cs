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
                c = new MySqlCommand("START TRANSACTION;",con);
                try
                {
                    c.ExecuteNonQuery();
                    long idLinije = unesiLinije(entity);
                    unesiStaniceULiniji(entity, idLinije);
                    unesiVoznje(entity, idLinije);
                    unesiRasporedeVoznje(entity, idLinije);
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

            private void unesiCijene(Linija entity, long idLinije)
            {
                if (entity.Cijene.Count != entity.Stanice.Count-1) throw new Exception("Nedovoljno unesenih cijena!");
                for (int i = 0; i < entity.Cijene.Count; i++)
                {
                    for (int j = 0; j < entity.Cijene[i].Count; j++)
                    {
                        c = new MySqlCommand(string.Format("INSERT INTO linijecijene VALUES ('','{0}','{1}','{2}','{3}');",
                            idLinije, entity.Stanice[i].SifraStanice, entity.Stanice[j].SifraStanice, entity.Cijene[i][j]), con);
                        c.ExecuteNonQuery();
                    }
                }
            }

            private void unesiRasporedeVoznje(Linija entity, long idLinije)
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

            private void unesiVoznje(Linija entity, long idLinije)
            {
                if (entity.Voznje.Count < 1) throw new Exception("Nedovoljno voznji u liniji");
                for (int i = 0; i < entity.Voznje.Count; i++)
                {
                    entity.Voznje[i].SifraVoznje = DAOFactory.Instanca.getVoznjaDAO().create(entity.Voznje[i]);
                    c = new MySqlCommand(string.Format("INSERT INTO linijevoznje VALUES ('','{0}','{1}');", idLinije, entity.Voznje[i].SifraVoznje), con);
                    c.ExecuteNonQuery();
                }
            }

            private long unesiLinije(Linija entity)
            {
                c = new MySqlCommand(String.Format("INSERT INTO linije VALUES ('','{0}');", entity.NazivLinije), con);
                c.ExecuteNonQuery();
                return c.LastInsertedId;
            }

            private void unesiStaniceULiniji(Linija entity, long idLinije)
            {
                if (entity.Stanice.Count < 2) throw new Exception("Nedovoljno stanica u liniji");
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

                    foreach (Voznja v in entity.Voznje)
                        DAOFactory.Instanca.getVoznjaDAO().delete(v);

                    foreach (RasporedVoznje rv in entity.RasporediVoznje)
                        DAOFactory.Instanca.getRasporedVoznjiDAO().delete(rv);

                    c = new MySqlCommand(string.Format("DELETE * FROM staniceuliniji WHERE idLinije='{0}'", entity.SifraLinije), con);
                    c.ExecuteNonQuery();

                    c = new MySqlCommand(string.Format("DELETE * FROM linijecijene WHERE idLinije='{0}'", entity.SifraLinije), con);
                    c.ExecuteNonQuery();

                    c = new MySqlCommand(string.Format("DELETE * FROM linije WHERE id='{0}'", entity.SifraLinije), con);
                    c.ExecuteNonQuery();

                }
                catch (Exception e)
                {
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
                    naziv = ucitajNaziv(id);
                    ucitavanjeIzStaniceULiniji(sifra, ref stanice, ref trajanjeDoDolaska, ref trajanjeDoPolaska);
                    ucitajVoznje(sifra, ref voznje);
                    ucitajRasporedVoznji(sifra, ref rasporediVoznje);

                    cijene = new List<List<double>>(stanice.Count);
                    for (int i = 0; i < stanice.Count; i++)
                        cijene[i] = new List<double>(stanice.Count - i - 1);

                    ucitajCijene(sifra, stanice.Count, ref cijene);
                }
                catch (Exception e)
                {
                    throw e;
                }

                return new Linija(sifra, naziv, stanice, trajanjeDoDolaska, trajanjeDoPolaska, cijene, voznje, rasporediVoznje);
            }

            #region funkcije za ucitavanje4
            private void ucitajCijene(long sifraLinije, int brStanica, ref List<List<double>> cijene)
            {
                c = new MySqlCommand(string.Format("SELECT lc.*, sul.trajanjeDoDolaska FROM (SELECT * FROM linijecijene WHERE idLinije='{0}') AS lc LEFT JOIN staniceuliniji AS sul ON sul.idLinije='{0}' AND sul.idStanice = lc.idPrveStanice ORDER BY sul.trajanjeDoDolaska;",
                    sifraLinije), con);
                MySqlDataReader r = c.ExecuteReader();

                int sifra1, sifra2;
                for (int i = 0; i < brStanica; i++)
                {
                    if (!r.Read()) throw new Exception("Neispravan broj cijena u tabeli");
                    for (int j = 0; j < brStanica - i - 1; j++)
                    {
                        sifra1 = r.GetInt16("idPrveStanice");
                        sifra2 = r.GetInt16("idDrugeStanice");
                        cijene[sifra1][sifra2] = r.GetDouble("cijena");
                    }
                }
                r.Close();
            }

            private void ucitajRasporedVoznji(long sifra, ref List<RasporedVoznje> rasporediVoznje)
            {
                rasporediVoznje = new List<RasporedVoznje>();
                c = new MySqlCommand(String.Format("SELECT * FROM linijerasporedvoznji WHERE idLinije='{0}';", sifra), con);
                MySqlDataReader r = c.ExecuteReader();
                long sifraRasporedaVoznje;
                while (r.Read())
                {
                    sifraRasporedaVoznje = r.GetInt32("idRasporedaVoznje");
                    rasporediVoznje.Add(DAOFactory.Instanca.getRasporedVoznjiDAO().getById(sifraRasporedaVoznje));
                }
                r.Close();
            }

            private void ucitajVoznje(long sifra, ref List<Voznja> voznje)
            {
                voznje = new List<Voznja>();
                c = new MySqlCommand(String.Format("SELECT idVoznje FROM linijevoznje WHERE idLinije='{0}';", sifra), con);
                long sifraVoznje;
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                {
                    sifraVoznje = r.GetInt32("idVoznje");
                    voznje.Add(DAOFactory.Instanca.getVoznjaDAO().getById(sifraVoznje));
                }
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

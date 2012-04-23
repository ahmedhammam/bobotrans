using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;

using DAL.Entiteti;
using DAL.Interfejsi;

namespace DAL
{
    partial class DAL
    {
        public class KupacKarteDAO : IDaoCrud<KupacKarte>
        {
            protected MySqlCommand c;

            public long create(KupacKarte entity)
            {
                try
                {

                    c = new MySqlCommand(String.Format("INSERT INTO KupciKarti VALUES ('','{0}','{1}');"
                        , entity.Ime, TipoviPodataka.TipoviKupaca.BEZ_POPUSTA)
                        , con);
                    c.ExecuteNonQuery();
                    long idKupca;
                    idKupca= c.LastInsertedId;

                    for (int i = 0; i<entity.Sjedista.Count;i++)
                    {
                        c = new MySqlCommand(String.Format("INSERT INTO Karte VALUES ('','{0}','{1}','{2}','{3}','{4}','{5}');"
                            ,entity.Voznja.SifraVoznje,entity.PocetnaStanica.SifraStanice,entity.KrajnjaStanica.SifraStanice,entity.Sjedista[i],entity.Cijene[i] ,entity.SifraKupca)
                            , con);
                    }




                    return idKupca;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public KupacKarte read(KupacKarte entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM KupciKarti WHERE imeIPrezime='{0}' AND tipKupca='{1}';", entity.Ime,TipoviPodataka.TipoviKupaca.BEZ_POPUSTA), con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        c = new MySqlCommand(String.Format("SELECT * FROM Karte WHERE idKupca='{0}'",r.GetInt32("id")), con);
                        MySqlDataReader r2 = c.ExecuteReader();
                        List<int>sjed = new List<int>();
                        List<double>cij = new List<double>();
                        int voznjaId = -1;
                        while (r2.Read())
                        {
                            sjed.Add(r2.GetInt32("idSjedista"));
                            cij.Add(r2.GetInt32("cijena"));
                            voznjaId=r2.GetInt32("idVoznje");
                        }
                        KupacKarte KupacKarte = new KupacKarte(r.GetInt32("id"), r.GetString("imeIPrezime"), (DAL.Instanca.getDAO.getStaniceDAO()).getById(r.GetInt32("idPocetneStanice")), (DAL.Instanca.getDAO.getStaniceDAO()).getById(r.GetInt32("idKrajnjeStanice")),(DAL.Instanca.getDAO.getVoznjaDAO()).getById(voznjaId), sjed, cij);
                        r2.Close();
                        r.Close();
                        return KupacKarte;
                    }
                    else throw
                     new Exception("nije nadjen nijedan element");

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public KupacKarte update(KupacKarte entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("DELETE FROM Karte WHERE idKupca='{0}';", entity.SifraKupca), con);
                    c.ExecuteNonQuery();

                    c = new MySqlCommand(String.Format("UPDATE KupciKarti SET imeIPrezime='{0}', tipKupca='{1}' WHERE id='{2}';", entity.Ime, TipoviPodataka.TipoviKupaca.BEZ_POPUSTA, entity.SifraKupca), con);
                    c.ExecuteNonQuery();

                    for (int i = 0; i < entity.Sjedista.Count; i++)
                    {
                        c = new MySqlCommand(String.Format("INSERT INTO Karte VALUES ('','{0}','{1}','{2}','{3}','{4}','{5}');"
                            , entity.Voznja.SifraVoznje, entity.PocetnaStanica.SifraStanice, entity.KrajnjaStanica.SifraStanice, entity.Sjedista[i], entity.Cijene[i], entity.SifraKupca)
                            , con);
                    }

                    return entity;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(KupacKarte entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("DELETE FROM Karte WHERE idKupca ='{0}';", entity.SifraKupca), con);
                    c.ExecuteNonQuery();

                    c = new MySqlCommand(String.Format("DELETE FROM KupciKarti WHERE id ='{0}';", entity.SifraKupca), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public KupacKarte getById(long id)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM KupciKarti WHERE id='{0}';", id), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        c = new MySqlCommand(String.Format("SELECT * FROM Karte WHERE idKupca='{0}'",id), con);
                        MySqlDataReader r2 = c.ExecuteReader();
                        List<int> sjed = new List<int>();
                        List<double> cij = new List<double>();
                        int voznjaId = -1;
                        while (r2.Read())
                        {
                            sjed.Add(r2.GetInt32("idSjedista"));
                            cij.Add(r2.GetInt32("cijena"));
                            voznjaId = r2.GetInt32("idVoznje");
                        }
                        KupacKarte KupacKarte = new KupacKarte(r.GetInt32("id"), r.GetString("imeIPrezime"), (DAL.Instanca.getDAO.getStaniceDAO()).getById(r.GetInt32("idPocetneStanice")), (DAL.Instanca.getDAO.getStaniceDAO()).getById(r.GetInt32("idKrajnjeStanice")), (DAL.Instanca.getDAO.getVoznjaDAO()).getById(voznjaId), sjed, cij);
                        r2.Close();
                        r.Close();
                        return KupacKarte;
                    }
                    else throw
                        new Exception("nije nadjen nijedan element");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<KupacKarte> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM KupciKarti WHERE tipKupca='{0}';",TipoviPodataka.TipoviKupaca.BEZ_POPUSTA), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<KupacKarte> KupacKartei = new List<KupacKarte>();
                    while (r.Read())
                    {
                        c = new MySqlCommand(String.Format("SELECT * FROM Karte WHERE idKupca='{0}'",r.GetInt32("id")), con);
                        MySqlDataReader r2 = c.ExecuteReader();
                        List<int> sjed = new List<int>();
                        List<double> cij = new List<double>();
                        int voznjaId = -1;
                        while (r2.Read())
                        {
                            sjed.Add(r2.GetInt32("idSjedista"));
                            cij.Add(r2.GetInt32("cijena"));
                            voznjaId = r2.GetInt32("idVoznje");
                        }
                        KupacKartei.Add(new KupacKarte(r.GetInt32("id"), r.GetString("imeIPrezime"), (DAL.Instanca.getDAO.getStaniceDAO()).getById(r.GetInt32("idPocetneStanice")), (DAL.Instanca.getDAO.getStaniceDAO()).getById(r.GetInt32("idKrajnjeStanice")), (DAL.Instanca.getDAO.getVoznjaDAO()).getById(voznjaId), sjed, cij));
                        r2.Close();
                    }
                    r.Close();
                    return KupacKartei;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<KupacKarte> getByExample(string name, string values)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM KupciKarti WHERE {0}='{1}' AND tipKupca='{2}';", name, values, TipoviPodataka.TipoviKupaca.BEZ_POPUSTA), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<KupacKarte> KupacKartei = new List<KupacKarte>();
                    while (r.Read())
                    {
                        c = new MySqlCommand(String.Format("SELECT * FROM Karte WHERE idKupca='{0}'", r.GetInt32("id")), con);
                        MySqlDataReader r2 = c.ExecuteReader();
                        List<int> sjed = new List<int>();
                        List<double> cij = new List<double>();
                        int voznjaId = -1;
                        while (r2.Read())
                        {
                            sjed.Add(r2.GetInt32("idSjedista"));
                            cij.Add(r2.GetInt32("cijena"));
                            voznjaId = r2.GetInt32("idVoznje");
                        }
                        KupacKartei.Add(new KupacKarte(r.GetInt32("id"), r.GetString("imeIPrezime"), (DAL.Instanca.getDAO.getStaniceDAO()).getById(r.GetInt32("idPocetneStanice")), (DAL.Instanca.getDAO.getStaniceDAO()).getById(r.GetInt32("idKrajnjeStanice")), (DAL.Instanca.getDAO.getVoznjaDAO()).getById(voznjaId), sjed, cij));
                        r2.Close();
                    }
                    r.Close();
                    return KupacKartei;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}

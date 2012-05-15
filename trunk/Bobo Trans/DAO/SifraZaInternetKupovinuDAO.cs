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
        public class SifraZaInternetKupovinuDAO : IDaoCrud<SifraZaInternetKupovinu>
        {
            protected MySqlCommand c;
            public long create(SifraZaInternetKupovinu entity)
            {
                try
                {

                    c = new MySqlCommand(String.Format("INSERT INTO internetrezervacije VALUES ('','{0}','{1}');"
                        , entity.SifraKorisnika, entity.Sifra)
                        , con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public SifraZaInternetKupovinu read(SifraZaInternetKupovinu entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM internetrezervacije WHERE idKupca='{0}' AND sifra='{1}';",
                        entity.SifraKorisnika,entity.Sifra), con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        SifraZaInternetKupovinu korisnik = new SifraZaInternetKupovinu(r.GetInt32("id"), r.GetInt32("idKupca"), r.GetString("sifra"));
                        r.Close();
                        return korisnik;
                    }
                    else
                    {
                        r.Close();
                        throw
                     new Exception("nije nadjen nijedan element");
                    }

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public SifraZaInternetKupovinu update(SifraZaInternetKupovinu entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("UPDATE internetrezervacije SET idKupca='{0}', sifra='{1}';",
                        entity.SifraKorisnika, entity.Sifra), con);
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(SifraZaInternetKupovinu entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("DELETE FROM internetrezervacije WHERE id ='{0}';", entity.IdSifre), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public SifraZaInternetKupovinu getById(long id)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM internetrezervacije WHERE id='{0}';", id), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        SifraZaInternetKupovinu a = new SifraZaInternetKupovinu(r.GetInt32("id"), r.GetInt32("idKupca"), r.GetString("sifra"));
                        r.Close();
                        return a;
                    }
                    else
                    {
                        r.Close();
                        throw
                        new Exception("nije nadjen nijedan element");
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<SifraZaInternetKupovinu> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM internetrezervacije;"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<SifraZaInternetKupovinu> korisnici = new List<SifraZaInternetKupovinu>();
                    while (r.Read())
                        korisnici.Add(new SifraZaInternetKupovinu(r.GetInt32("id"), r.GetInt32("idKupca"), r.GetString("sifra")));

                    r.Close();
                    return korisnici;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<SifraZaInternetKupovinu> getByExample(string name, string values)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM internetrezervacije WHERE {0}='{1}';",name,values), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<SifraZaInternetKupovinu> korisnici = new List<SifraZaInternetKupovinu>();
                    while (r.Read())
                        korisnici.Add(new SifraZaInternetKupovinu(r.GetInt32("id"), r.GetInt32("idKupca"), r.GetString("sifra")));

                    r.Close();
                    return korisnici;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
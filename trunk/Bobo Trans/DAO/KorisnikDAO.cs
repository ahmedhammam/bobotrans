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
        public class KorisnikDAO:IDaoCrud<Korisnik>
        {
            protected MySqlCommand c;
            public long create(Korisnik entity)
            {
                try
                {

                    c = new MySqlCommand(String.Format("INSERT INTO korisnici VALUES ('','{0}','{1}','{2}','{3}');"
                        , entity.ImeIPrezime,(int)entity.Tip,entity.Username,entity.Password)
                        , con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Korisnik read(Korisnik entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM korisnici WHERE imeIPrezime='{0}' AND tip='{1}' AND username='{2}' AND lozinka='{3}';", 
                        entity.ImeIPrezime,(int)(entity.Tip),entity.Username,entity.Password), con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        Korisnik korisnik = new Korisnik(r.GetInt32("id"), r.GetString("username"), r.GetString("imeIPrezime"), (TipoviPodataka.TipoviKorisnika)r.GetInt32("tip"), r.GetString("lozinka"));
                        return korisnik;
                    }
                    else throw
                     new Exception("nije nadjen nijedan element");

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Korisnik update(Korisnik entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("UPDATE korisnici SET imeIPrezime='{0}', tip='{1}', username='{2}', lozinka='{4}' WHERE id='{3}';",
                        entity.ImeIPrezime, (int)entity.Tip, entity.Username, entity.SifraKorisnika,entity.Password), con);
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(Korisnik entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("DELETE FROM korisnici WHERE id ='{0}';", entity.SifraKorisnika), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Korisnik getById(long id)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM korisnici WHERE id='{0}';", id), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Korisnik a = new Korisnik(r.GetInt32("id"), r.GetString("username"), r.GetString("imeIPrezime"), (TipoviPodataka.TipoviKorisnika)r.GetInt32("tip"), r.GetString("lozinka"));
                        return a;
                    }
                    else throw
                        new Exception("nije nadjen nijedan element");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Korisnik> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM korisnici;"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Korisnik> korisnici = new List<Korisnik>();
                    while (r.Read())
                        korisnici.Add(new Korisnik(r.GetInt32("id"), r.GetString("username"), r.GetString("imeIPrezime"), (TipoviPodataka.TipoviKorisnika)r.GetInt32("tip"), r.GetString("lozinka")));

                    return korisnici;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Korisnik> getByExample(string name, string values)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM korisnici WHERE {0}='{1}';", name, values), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Korisnik> korisnici = new List<Korisnik>();
                    while (r.Read())
                        korisnici.Add(new Korisnik(r.GetInt32("id"), r.GetString("username"), r.GetString("imeIPrezime"), (TipoviPodataka.TipoviKorisnika)r.GetInt32("tip"), r.GetString("lozinka")));

                    return korisnici;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Korisnik getByUsernameAndPassword(string username, string password)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM korisnici WHERE username='{0}' AND lozinka='{1}';",
                        username,password), con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        Korisnik korisnik = new Korisnik(r.GetInt32("id"), r.GetString("username"), r.GetString("imeIPrezime"), (TipoviPodataka.TipoviKorisnika)r.GetInt32("tip"), r.GetString("lozinka"));
                        return korisnik;
                    }
                    else throw
                     new Exception("Nepostojeci korisnik!");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}

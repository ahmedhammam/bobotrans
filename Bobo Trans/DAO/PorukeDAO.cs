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
        public class PorukeDAO:IDaoCrud<Poruka>
        {
            protected MySqlCommand c;
            
            public long create(Poruka entity)
            {
                try
                {
                    Korisnik posiljaoc = (DAL.Instanca.getDAO.getKorisnikDAO()).getByExample("username",entity.Posiljaoc)[0];
                    Korisnik primalac = (DAL.instanca.getDAO.getKorisnikDAO()).getByExample("username", entity.Primalac)[0];

                    c = new MySqlCommand(String.Format("INSERT INTO poruke VALUES ('','{0}','{1}','{2}','{3}');"
                        , posiljaoc.SifraKorisnika, primalac.SifraKorisnika,entity.VrijemeSlanja.ToString("yyyy-MM-dd HH:mm"),entity.Tekst)
                        , con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            
            public Poruka read(Poruka entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT p.id,p.vrijemeSlanja,p.tekst,posiljaoc.id AS idPosiljaoca, primaoc.id AS idPrimaoca FROM poruke AS p LEFT JOIN korisnici as posiljaoc ON posiljaoc.username='{0}' LEFT JOIN korisnici as primaoc ON primaoc.username='{1}' ", 
                        entity.Posiljaoc,entity.Primalac), con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        Poruka poruka = new Poruka(r.GetInt32("id"),r.GetString("tekst"),r.GetString("posiljaoc"), r.GetString("primalac"), r.GetDateTime("vrijemeSlanja"));
                        r.Close();
                        return poruka;
                    }
                    else throw
                     new Exception("nije nadjen nijedan element");

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            
            public Poruka update(Poruka entity)
            {
                try
                {
                    Korisnik posiljaoc = (DAL.Instanca.getDAO.getKorisnikDAO()).getByExample("username", entity.Posiljaoc)[0];
                    Korisnik primalac = (DAL.Instanca.getDAO.getKorisnikDAO()).getByExample("username", entity.Primalac)[0];

                    c = new MySqlCommand(String.Format("UPDATE poruke SET idPosiljaoca='{0}', idPrimaoca='{1}', vrijemeSlanja='{2}', tekst = '{4}' WHERE id='{3}';",
                        posiljaoc.SifraKorisnika, primalac.SifraKorisnika, entity.VrijemeSlanja.ToString("yyyy-MM-dd HH:mm"), entity.SifraPoruke, entity.Tekst), con);
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            
            public void delete(Poruka entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("DELETE FROM poruke WHERE id ='{0}';", entity.SifraPoruke), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            
            public Poruka getById(long id)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT p.id,p.vrijemeSlanja,p.tekst, posiljaoc.username AS usernamePosiljaoca, primaoc.username AS usernamePrimaoca FROM (SELECT * FROM poruke WHERE id='{0}') AS p LEFT JOIN korisnici as posiljaoc ON posiljaoc.id =  p.idPosiljaoca LEFT JOIN korisnici as primaoc ON primaoc.id= p.idPrimaoca;", id), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Poruka a = new Poruka(r.GetInt32("id"), r.GetString("tekst"), r.GetString("usernamePosiljaoca"), r.GetString("usernamePrimaoca"), r.GetDateTime("vrijemeSlanja"));
                        r.Close();
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
            
            public List<Poruka> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT p.id,p.vrijemeSlanja,p.tekst, posiljaoc.username AS usernamePosiljaoca, primaoc.username AS usernamePrimaoca FROM poruke AS p LEFT JOIN korisnici as posiljaoc ON posiljaoc.id =  p.idPosiljaoca LEFT JOIN korisnici as primaoc ON primaoc.id= p.idPrimaoca;"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Poruka> poruke = new List<Poruka>();
                    while (r.Read())
                        poruke.Add(new Poruka(r.GetInt32("id"), r.GetString("tekst"), r.GetString("usernamePosiljaoca"), r.GetString("usernamePrimaoca"), r.GetDateTime("vrijemeSlanja")));
                    r.Close();
                    return poruke;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            
            public List<Poruka> getByExample(string name, string values)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT p.id,p.vrijemeSlanja,p.tekst, posiljaoc.username AS usernamePosiljaoca, primaoc.username AS usernamePrimaoca FROM (SELECT * FROM poruke WHERE {0}='{1}') AS p LEFT JOIN korisnici as posiljaoc ON posiljaoc.id =  p.idPosiljaoca LEFT JOIN korisnici as primaoc ON primaoc.id= p.idPrimaoca;",name,values), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Poruka> poruke = new List<Poruka>();
                    while (r.Read())
                        poruke.Add(new Poruka(r.GetInt32("id"), r.GetString("tekst"), r.GetString("usernamePosiljaoca"), r.GetString("usernamePrimaoca"), r.GetDateTime("vrijemeSlanja")));
                    r.Close();
                    return poruke;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}

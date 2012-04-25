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
        public class VoznjaDAO:IDaoCrud<Voznja>
        {
            protected MySqlCommand c;
            public long create(Voznja entity)
            {
                try
                {

                    c = new MySqlCommand(String.Format("INSERT INTO voznje VALUES ('','{0}','{1}','{2}','{3}');"
                        , entity.Autobus.SifraAutobusa, entity.VrijemePolaska.ToString("yyyy-MM-dd"),entity.VrijemePolaska.Hour,entity.VrijemePolaska.Minute)
                        , con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Voznja read(Voznja entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM voznje WHERE idAutobusa='{0}' AND vrijemePolaska='{1}' AND sati='{2}' AND minute='{3}'",
                        entity.Autobus.SifraAutobusa, entity.VrijemePolaska.ToString("yyyy-MM-dd"),entity.VrijemePolaska.Hour,entity.VrijemePolaska.Minute), con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        DateTime dt = r.GetDateTime("vrijemePolaska");
                        Voznja voznja = new Voznja(r.GetInt32("id"),new DateTime(dt.Year,dt.Month,dt.Day,r.GetInt16("sati"),r.GetInt16("minute"),0), entity.Autobus);
                        r.Close();
                        return voznja;
                    }
                    else throw
                     new Exception("nije nadjen nijedan element");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Voznja update(Voznja entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("UPDATE voznje SET idAutobusa='{0}', vrijemePolaska='{1}', sati = '{2}', minute = '{3}' WHERE id='{4}';", 
                        entity.Autobus.SifraAutobusa, entity.VrijemePolaska.ToString("yyyy-MM-dd"),entity.VrijemePolaska.Hour,entity.VrijemePolaska.Minute, entity.SifraVoznje), con);
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(Voznja entity)
            {
                try
                {
                    Console.WriteLine(entity.SifraVoznje);
                    c = new MySqlCommand(String.Format("DELETE FROM voznje WHERE id ='{0}';", entity.SifraVoznje), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Voznja getById(long id)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM voznje WHERE id='{0}';", id), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        DateTime dt = r.GetDateTime("vrijemePolaska");
                        long sifra = r.GetInt32("id");
                        dt = new DateTime(dt.Year,dt.Month,dt.Day,r.GetInt16("sati"), r.GetInt16("minute"),0);
                        long sifraAutobusa = r.GetInt32("idAutobusa");
                        r.Close();
                        return new Voznja(sifra, dt, DAL.Instanca.getDAO.getAutobusDAO().getById(sifraAutobusa));
                    }
                    else throw
                        new Exception("nije nadjen nijedan element");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Voznja> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM voznje;"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Voznja> voznje = new List<Voznja>();

                    List<DateTime> datumi = new List<DateTime>();
                    List<long> sifre = new List<long>();
                    List<long> sifreAutobusa = new List<long>();

                    DateTime dt;
                    while (r.Read())
                    {
                        dt = r.GetDateTime("vrijemePolaska");
                        sifre.Add(r.GetInt32("id"));
                        datumi.Add(new DateTime(dt.Year, dt.Month, dt.Day, r.GetInt16("sati"), r.GetInt16("minute"), 0));
                        sifreAutobusa.Add(r.GetInt32("idAutobusa"));
                    }
                    r.Close();
                    for (int i = 0; i < sifre.Count; i++)
                        voznje.Add(new Voznja(sifre[i], datumi[i], DAL.Instanca.getDAO.getAutobusDAO().getById(sifreAutobusa[i])));
                    return voznje;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Voznja> getByExample(string name, string values)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM voznje WHERE {0}='{1}';", name, values), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Voznja> voznje = new List<Voznja>();
                    List<DateTime> datumi = new List<DateTime>();
                    List<long> sifre = new List<long>();
                    List<long> sifreAutobusa = new List<long>();

                    DateTime dt;
                    while (r.Read())
                    {
                        dt = r.GetDateTime("vrijemePolaska");
                        sifre.Add(r.GetInt32("id"));
                        datumi.Add(new DateTime(dt.Year, dt.Month, dt.Day, r.GetInt16("sati"), r.GetInt16("minute"), 0));
                        sifreAutobusa.Add(r.GetInt32("idAutobusa"));
                    }
                    r.Close();
                    for (int i = 0; i < sifre.Count; i++)
                        voznje.Add(new Voznja(sifre[i], datumi[i], DAL.Instanca.getDAO.getAutobusDAO().getById(sifreAutobusa[i])));
                    return voznje;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}

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

                    c = new MySqlCommand(String.Format("INSERT INTO voznje VALUES ('','{0}','{1}');"
                        , entity.Autobus.SifraAutobusa, entity.VrijemePolaska.ToString("yyyy-MM-dd HH:mm"))
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
                    c = new MySqlCommand(String.Format("SELECT * FROM voznje WHERE idAutobusa='{0}' AND vrijemePolaska='{1}'",
                        entity.Autobus.SifraAutobusa, entity.VrijemePolaska.ToString("yyyy-MM-dd HH:mm")), con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        Voznja voznja = new Voznja(r.GetInt32("id"), r.GetDateTime("vrijemePolaska"), entity.Autobus);
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
                    c = new MySqlCommand(String.Format("UPDATE voznje SET idAutobusa='{0}', vrijemePolaska='{1}' WHERE id='{2}';", 
                        entity.Autobus.SifraAutobusa, entity.VrijemePolaska.ToString("yyyy-MM-dd HH:mm"), entity.SifraVoznje), con);
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
                    c = new MySqlCommand(String.Format("DELETE FROM voznje WHERE id ='{0}';", entity.SifraVoznje), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Voznja getById(int id)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM voznje WHERE id='{0}';", id), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Voznja v = new Voznja(r.GetInt32("id"), r.GetDateTime("vrijemePolaska"),DAL.Instanca.getDAO.getAutobusDAO().getById(r.GetInt32("idAutobusa")));
                        return v;
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
                    while (r.Read())
                        voznje.Add(new Voznja(r.GetInt32("id"), r.GetDateTime("vrijemePolaska"),DAL.Instanca.getDAO.getAutobusDAO().getById(r.GetInt32("idAutobusa"))));

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
                    while (r.Read())
                        voznje.Add(new Voznja(r.GetInt32("id"), r.GetDateTime("vrijemePolaska"), DAL.Instanca.getDAO.getAutobusDAO().getById(r.GetInt32("idAutobusa"))));
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

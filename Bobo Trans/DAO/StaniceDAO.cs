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
        public class StanicaDAO : IDaoCrud<Stanica>
        {
            protected MySqlCommand c;

            public long create(Stanica entity)
            {
                try
                {

                    c = new MySqlCommand(String.Format("INSERT INTO Stanice VALUES ('','{0}','{1}');"
                        , entity.Naziv, entity.Mjesto)
                        , con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Stanica read(Stanica entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM Stanice WHERE naziv='{0}' AND mjesto='{1}' AND idKreatora='{2}'", entity.Naziv, entity.Mjesto), con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        Stanica Stanica = new Stanica(r.GetInt32("id"), r.GetString("naziv"), r.GetString("mjesto"));
                        r.Close();
                        return Stanica;
                    }
                    else
                    {
                        r.Close();
                        throw new Exception("nije nadjen nijedan element");
                    }

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Stanica update(Stanica entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("UPDATE Stanice SET naziv='{0}', mjesto='{1}' WHERE id='{3}';", entity.Naziv, entity.Mjesto, entity.SifraStanice), con);
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(Stanica entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("DELETE FROM Stanice WHERE id ='{0}';", entity.SifraStanice), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Stanica getById(long id)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM Stanice WHERE id='{0}';", id), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Stanica a = new Stanica(r.GetInt32("id"), r.GetString("naziv"), r.GetString("mjesto"));
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

            public List<Stanica> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM Stanice;"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Stanica> Stanice = new List<Stanica>();
                    while (r.Read())
                        Stanice.Add(new Stanica(r.GetInt32("id"), r.GetString("naziv"), r.GetString("mjesto")));
                    r.Close();
                    return Stanice;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Stanica> getByExample(string name, string values)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM Stanice WHERE {0}='{1}';", name, values), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Stanica> Stanice = new List<Stanica>();
                    while (r.Read())
                        Stanice.Add(new Stanica(r.GetInt32("id"), r.GetString("naziv"), r.GetString("mjesto")));
                    r.Close();
                    return Stanice;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}

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
        class AutobusDAO:IDaoCrud<Autobus>
        {
            protected MySqlCommand c;

            public long create(Autobus entity)
            {
                try
                {
                    c = new MySqlCommand("INSERT INTO autobusi VALUES ('"+entity.RegistracijskeTablice+ "," + entity.IstekRegistracije+","+ entity.BrojSjedista+","+entity.DatumServisa
                        + "," + Convert.ToInt16(entity.ImaToalet) + "," + Convert.ToInt16(entity.Slobodan) + "," + Convert.ToInt16(entity.ImaKlimu)+"');", con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Autobus read(Autobus entity)
            {
                throw new NotImplementedException();
            }

            public Autobus update(Autobus entity)
            {
                try
                {
                    c = new MySqlCommand("UPDATE autobusi SET registracijskeTablice="+entity.RegistracijskeTablice+", istekRegistracije="+entity.IstekRegistracije+", brojSjedista = "
                        +entity.BrojSjedista+" , datumServisa="+entity.DatumServisa+", toalet="+Convert.ToInt16(entity.ImaToalet)+", slobodan = "+Convert.ToInt16(entity.Slobodan)
                        +", klima="+Convert.ToInt16(entity.ImaKlimu)
                        +"WHERE id="+entity.SifraAutobusa+";",con);
                    c.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    throw e;
                }
            }

            public void delete(Autobus entity)
            {
                try
                {
                    c = new MySqlCommand("DELETE FROM autobusi WHERE id ="+entity.SifraAutobusa, con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Autobus getById(int id)
            {
                try
                {
                    c = new MySqlCommand("SELECT * FROM autobusi WHERE id=" + id + ";", con);
                    MySqlDataReader r = c.ExecuteReader();
                    Autobus a = new Autobus(id,r.GetInt32("brojSjedista"),r.GetString("registracijskeTablice"),r.GetBoolean("toalet"),r.GetBoolean("slobodan"),r.GetBoolean("klima"),r.GetDateTime("istekRegistracije"), r.GetDateTime("datumServisa"));
                    return a;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Autobus> GetAll()
            {
                try
                {
                    c = new MySqlCommand("SELECT * FROM autobusi;", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Autobus> autobusi = new List<Autobus>();
                    while (r.Read()) 
                          autobusi.Add(new Autobus(r.GetInt32("id"), r.GetInt32("brojSjedista"), r.GetString("registracijskeTablice"), r.GetBoolean("toalet"), 
                              r.GetBoolean("slobodan"), r.GetBoolean("klima"), r.GetDateTime("istekRegistracije"), r.GetDateTime("datumServisa")));
                    return autobusi;
                    
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Autobus> getByExample(string name, string values)
            {
                try
                {
                    c = new MySqlCommand("SELECT * FROM autobusi; WHERE "+name+"="+values+";", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Autobus> autobusi = new List<Autobus>();
                    while (r.Read())
                        autobusi.Add(new Autobus(r.GetInt32("id"), r.GetInt32("brojSjedista"), r.GetString("registracijskeTablice"), r.GetBoolean("toalet"),
                            r.GetBoolean("slobodan"), r.GetBoolean("klima"), r.GetDateTime("istekRegistracije"), r.GetDateTime("datumServisa")));
                    return autobusi;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}

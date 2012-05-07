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
        public class RasporedVoznjeAutobusDAO:IDaoCrud<RasporedVoznjeAutobus>
        {

            protected MySqlCommand c;

            public long create(RasporedVoznjeAutobus entity)
            {
                try
                {

                    c = new MySqlCommand(String.Format("INSERT INTO rasporedvoznjeautobus VALUES ('','{0}','{1}');"
                        , entity.RasporedVoznje,entity.Autobus)
                        , con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public RasporedVoznjeAutobus read(RasporedVoznjeAutobus entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM rasporedvoznjeautobus WHERE idRasporedaVoznje='{0}' AND idAutobusa='{1}'",
                        entity.RasporedVoznje,entity.Autobus), con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        RasporedVoznjeAutobus rva =  new RasporedVoznjeAutobus(r.GetInt32("idAutobusa"), r.GetInt32("idRasporedaVoznje"));
                        r.Close();
                        return rva;
                    }
                    else throw
                     new Exception("nije nadjen nijedan element");

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public RasporedVoznjeAutobus update(RasporedVoznjeAutobus entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("UPDATE rasporedvoznjeautobus SET idRasporedaVoznje='{0}', idAutobusa='{1}' WHERE id='{2}';",
                        entity.RasporedVoznje,entity.Autobus,entity.SifraRasporedaVoznjeAutobus), con);
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(RasporedVoznjeAutobus entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("DELETE FROM rasporedvoznjeautobus WHERE id ='{0}';", entity.SifraRasporedaVoznjeAutobus), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public RasporedVoznjeAutobus getById(long id)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM rasporedvoznjeautobus WHERE id='{0}';", id), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        RasporedVoznjeAutobus rva = new RasporedVoznjeAutobus(id,r.GetInt32("idAutobusa"), r.GetInt32("idRasporedaVoznje"));
                        r.Close();
                        return rva;
                    }
                    else throw
                        new Exception("nije nadjen nijedan element");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<RasporedVoznjeAutobus> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM rasporedvoznjeautobus;"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<RasporedVoznjeAutobus> rva = new List<RasporedVoznjeAutobus>();
                    while (r.Read())
                        rva.Add(new RasporedVoznjeAutobus(r.GetInt32("id"),r.GetInt32("idAutobusa"), r.GetInt32("idRasporedaVoznje")));

                    r.Close();
                    return rva;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<RasporedVoznjeAutobus> getByExample(string name, string values)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM rasporedvoznjeautobus WHERE {0}='{1}';", name, values), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<RasporedVoznjeAutobus> rva = new List<RasporedVoznjeAutobus>();
                    while (r.Read())
                        rva.Add(new RasporedVoznjeAutobus(r.GetInt32("id"), r.GetInt32("idAutobusa"), r.GetInt32("idRasporedaVoznje")));

                    r.Close();
                    return rva;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<RasporedVoznjeAutobus> dajRasporedeULiniji(long sifraLinije)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT rva.id, rva.idAutobusa, rva.idRasporedaVoznje FROM (SELECT * FROM linijerasporedvoznji WHERE idLinije='{0}' ) AS lrv LEFT JOIN rasporedvoznjeautobus as rva ON lrv.idRasporedaVoznje = rva.idRasporedaVoznje;",
                        sifraLinije), con);

                    MySqlDataReader r = c.ExecuteReader();
                    List<RasporedVoznjeAutobus> rva = new List<RasporedVoznjeAutobus>();
                    while (r.Read())
                        rva.Add(new RasporedVoznjeAutobus(r.GetInt32("id"), r.GetInt32("idAutobusa"), r.GetInt32("idRasporedaVoznje")));

                    r.Close();
                    return rva;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}

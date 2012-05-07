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
        public class RasporedVoznjeDAO:IDaoCrud<RasporedVoznje>
        {
            protected MySqlCommand c;

            public long create(RasporedVoznje entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("INSERT INTO rasporedvoznji VALUES ('','{0}','{1}','{2}','{3}');"
                        , entity.DanUSedmici, entity.Vrijeme.Hour,entity.Vrijeme.Minute, entity.PotrebanBrojSjedista)
                        , con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public RasporedVoznje read(RasporedVoznje entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM rasporedvoznji WHERE danUSedmici='{0}' AND sati='{1}' AND minute='{2}' AND potrebanBrojSjedista='{3}'",
                        entity.DanUSedmici,entity.Vrijeme.Hour,entity.Vrijeme.Minute,entity.PotrebanBrojSjedista, con));

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        RasporedVoznje rv = new RasporedVoznje(r.GetInt32("id"), r.GetInt32("danUSedmici"), new DateTime(1, 1, 1, r.GetInt32("sati"), r.GetInt32("minute"), 0), r.GetInt32("potrebanBrojSjedista"));
                        r.Close();
                        return rv;
                    }
                    else throw
                     new Exception("nije nadjen nijedan element");

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public RasporedVoznje update(RasporedVoznje entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("UPDATE rasporedvoznji SET danUSedmici='{0}', sati='{1}', minute='{2}', potrebanBrojSjedista='{3}' WHERE id='{4}';", 
                        entity.DanUSedmici,entity.Vrijeme.Hour,entity.Vrijeme.Minute,entity.PotrebanBrojSjedista,entity.SifraRasporedaVoznji), con);
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(RasporedVoznje entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("DELETE FROM rasporedvoznji WHERE id ='{0}';", entity.SifraRasporedaVoznji), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public RasporedVoznje getById(long id)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM rasporedvoznji WHERE id='{0}';", id), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        RasporedVoznje a = new RasporedVoznje(r.GetInt32("id"), r.GetInt32("danUSedmici"), new DateTime(1, 1, 1, r.GetInt32("sati"), r.GetInt32("minute"), 0), r.GetInt32("potrebanBrojSjedista"));
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

            public List<RasporedVoznje> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM rasporedvoznji;"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<RasporedVoznje> rv = new List<RasporedVoznje>();
                    while (r.Read())
                        rv.Add(new RasporedVoznje(r.GetInt32("id"), r.GetInt32("danUSedmici"), new DateTime(1, 1, 1, r.GetInt32("sati"), r.GetInt32("minute"), 0), r.GetInt32("potrebanBrojSjedista")));
                    r.Close();
                    return rv;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<RasporedVoznje> getByExample(string name, string values)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM rasporedvoznji WHERE {0}='{1}';", name, values), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<RasporedVoznje> rv = new List<RasporedVoznje>();
                    while (r.Read())
                        rv.Add(new RasporedVoznje(r.GetInt32("id"), r.GetInt32("danUSedmici"), new DateTime(1, 1, 1, r.GetInt32("sati"), r.GetInt32("minute"), 0), r.GetInt32("potrebanBrojSjedista")));
                    r.Close();
                    return rv;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            private void deletePoSifriRasporeda(long sifraRasporeda)
            {
                try
                {
                    c = new MySqlCommand(String.Format("DELETE FROM rasporedvoznji WHERE id ='{0}';", sifraRasporeda), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void deletePoSifriLinije(long idLinije)
            {
                try
                {

                    c = new MySqlCommand("START TRANSACTION;", con);
                    c.ExecuteNonQuery();

                    c = new MySqlCommand(string.Format("SELECT rv.id FROM (SELECT * FROM linijerasporedvoznji WHERE idLinije = '{0}' ) AS lrv LEFT JOIN rasporedvoznji as rv ON rv.id = lrv.idRasporedaVoznje;", 
                        idLinije), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<long> sifre = new List<long>();
                    while (r.Read())
                    {
                        sifre.Add(r.GetInt32("id"));
                    }
                    r.Close();
                    foreach (int i in sifre)
                        deletePoSifriRasporeda(i);
                    c = new MySqlCommand("COMMIT;", con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    c = new MySqlCommand("ROLLBACK;", con);
                    c.ExecuteNonQuery();
                    throw e;
                }
            }
        }
    }
}

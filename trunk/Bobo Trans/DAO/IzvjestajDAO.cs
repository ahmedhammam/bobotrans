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
        public class IzvjestajDAO:IDaoCrud<Izvjestaj>
        {
            protected MySqlCommand c;

            public long create(Izvjestaj entity)
            {
                try
                {

                    c = new MySqlCommand(String.Format("INSERT INTO izvjestaji VALUES ('','{0}','{1}','{2}');"
                        , entity.DatumServisa.ToString("yyyy-MM-dd"), entity.Tekst, entity.SifraKreatora)
                        , con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Izvjestaj read(Izvjestaj entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM izvjestaji WHERE datum='{0}' AND tekst='{1}' AND idKreatora='{2}'", entity.DatumServisa.ToString("yyyy-MM-dd"), entity.Tekst, entity.SifraKreatora), con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        Izvjestaj izvjestaj = new Izvjestaj(r.GetInt32("id"), r.GetDateTime("datum"), r.GetString("tekst"), r.GetInt32("idKreatora"));
                        return izvjestaj;
                    }
                    else throw
                     new Exception("nije nadjen nijedan element");

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Izvjestaj update(Izvjestaj entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("UPDATE izvjestaji SET datum='{0}', tekst='{1}', idKreatora='{2}' WHERE id='{3}';", entity.DatumServisa.ToString("yyyy-MM-dd"), entity.Tekst, entity.SifraKreatora, entity.SifraIzvjestaja), con);
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(Izvjestaj entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("DELETE FROM izvjestaji WHERE id ='{0}';", entity.SifraIzvjestaja), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Izvjestaj getById(long id)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM izvjestaji WHERE id='{0}';", id), con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Izvjestaj a = new Izvjestaj(r.GetInt32("id"), r.GetDateTime("datum"), r.GetString("tekst"), r.GetInt32("idKreatora"));
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

            public List<Izvjestaj> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM izvjestaji;"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Izvjestaj> izvjestaji = new List<Izvjestaj>();
                    while (r.Read())
                        izvjestaji.Add(new Izvjestaj(r.GetInt32("id"), r.GetDateTime("datum"), r.GetString("tekst"), r.GetInt32("idKreatora")));

                    return izvjestaji;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Izvjestaj> getByExample(string name, string values)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM izvjestaji WHERE {0}='{1}';", name, values), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Izvjestaj> izvjestaji = new List<Izvjestaj>();
                    while (r.Read())
                        izvjestaji.Add(new Izvjestaj(r.GetInt32("id"), r.GetDateTime("datum"), r.GetString("tekst"), r.GetInt32("idKreatora")));
                    return izvjestaji;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}

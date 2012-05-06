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
        public class ZakupacAutobusaDAO : IDaoCrud<ZakupacAutobusa>
        {
            protected MySqlCommand c;

            public long create(ZakupacAutobusa entity)
            {
                try
                {

                    c = new MySqlCommand(String.Format("INSERT INTO zakupiautobusa VALUES ('','{0}','{1}','{2}','{3}','{4}');"
                        , entity.Ime, entity.Autobus.SifraAutobusa, entity.Cijena 
                        , entity.PocetakZakupa.ToString("yyyy-MM-dd"), entity.KrajZakupa.ToString("yyyy-MM-dd"))
                        , con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public ZakupacAutobusa read(ZakupacAutobusa entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM ZakupiAutobusa WHERE imeZakupca='{0}' AND idAutobusa='{1}' AND cijena='{2}' AND pocetakZakupa=='{3}' AND krajZakupa='{4}';"
                        , entity.Ime, entity.Autobus.SifraAutobusa, entity.Cijena 
                        , entity.PocetakZakupa.ToString("yyyy-MM-dd"), entity.KrajZakupa.ToString("yyyy-MM-dd"))
                        , con);

                    MySqlDataReader r = c.ExecuteReader();

                    if (r.Read())
                    {
                        ZakupacAutobusa ZakupacAutobusa = new ZakupacAutobusa(r.GetInt32("id"), r.GetString("imeZakupca"), r.GetDateTime("pocetakZakupa"), r.GetDateTime("krajZakupa"), r.GetDouble("cijena"),(DAL.Instanca.getDAO.getAutobusDAO()).getById(r.GetInt32("idAutobusa")));
                        r.Close();
                        return ZakupacAutobusa;
                    }
                    else throw
                     new Exception("nije nadjen nijedan element");

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public ZakupacAutobusa update(ZakupacAutobusa entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("UPDATE ZakupacAutobusai SET imeZakupca='{0}', idAutobusa='{1}', cijena='{2}', pocetakZakupa=='{3}', krajZakupa='{4}' WHERE id='{5}';"
                        , entity.Ime, entity.Autobus.SifraAutobusa, entity.Cijena
                        , entity.PocetakZakupa.ToString("yyyy-MM-dd"), entity.KrajZakupa.ToString("yyyy-MM-dd")
                        , entity.SifraKupca)
                        , con);
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(ZakupacAutobusa entity)
            {
                try
                {
                    c = new MySqlCommand(String.Format("DELETE FROM zakupiautobusa WHERE id ='{0}';", entity.SifraKupca), con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public ZakupacAutobusa getById(long id)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM zakupiautobusa WHERE id='{0}';", id), con);
                    MySqlDataReader r = c.ExecuteReader();
                    long sifra;
                    string imeZakupca;
                    DateTime pocetak,kraj;
                    double cijena;
                    long idAutobusa;
                    if (r.Read())
                    {
                        sifra = r.GetInt32("id");
                        imeZakupca = r.GetString("imeZakupca");
                        pocetak = r.GetDateTime("pocetakZakupa"); kraj = r.GetDateTime("krajZakupa");
                        cijena = r.GetDouble("cijena");
                        idAutobusa = r.GetInt32("idAutobusa");
                        r.Close();
                    }
                    else throw
                        new Exception("nije nadjen nijedan element");

                    Autobus a = (DAL.Instanca.getDAO.getAutobusDAO()).getById(idAutobusa);

                    return new ZakupacAutobusa(sifra,imeZakupca, pocetak, kraj, cijena,a);
                    
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<ZakupacAutobusa> GetAll()
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM zakupiautobusa;"), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<ZakupacAutobusa> zakupacAutobusa = new List<ZakupacAutobusa>();
                    List<long> sifre = new List<long>(), sifreAutobusa = new List<long>();
                    List<DateTime> pocetak = new List<DateTime>(), kraj = new List<DateTime>();
                    List<string> imena = new List<string>();
                    List<double> cijene = new List<double>();
                    List<Autobus> autobusi = new List<Autobus>();

                    while (r.Read())
                    {
                        sifre.Add(r.GetInt32("id"));
                        imena.Add(r.GetString("imeZakupca"));
                        pocetak.Add(r.GetDateTime("pocetakZakupa"));
                        kraj.Add(r.GetDateTime("krajZakupa"));
                        cijene.Add(r.GetDouble("cijena"));
                        sifreAutobusa.Add(r.GetInt32("idAutobusa"));
                    }   
                     r.Close();

                     for (int i = 0; i < sifre.Count; i++ )
                     {
                         zakupacAutobusa.Add(new ZakupacAutobusa(sifre[i],imena[i],pocetak[i],kraj[i],cijene[i],Instanca.getDAO.getAutobusDAO().getById(sifreAutobusa[i])));
                     }
                    return zakupacAutobusa;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<ZakupacAutobusa> getByExample(string name, string values)
            {
                try
                {
                    c = new MySqlCommand(String.Format("SELECT * FROM zakupiautobusa WHERE {0}='{1}';", name, values), con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<ZakupacAutobusa> zakupacAutobusa = new List<ZakupacAutobusa>();
                    List<long> sifre = new List<long>(), sifreAutobusa = new List<long>();
                    List<DateTime> pocetak = new List<DateTime>(), kraj = new List<DateTime>();
                    List<string> imena = new List<string>();
                    List<double> cijene = new List<double>();
                    List<Autobus> autobusi = new List<Autobus>();

                    while (r.Read())
                    {
                        sifre.Add(r.GetInt32("id"));
                        imena.Add(r.GetString("imeZakupca"));
                        pocetak.Add(r.GetDateTime("pocetakZakupa"));
                        kraj.Add(r.GetDateTime("krajZakupa"));
                        cijene.Add(r.GetDouble("cijena"));
                        sifreAutobusa.Add(r.GetInt32("idAutobusa"));
                    }
                    r.Close();

                    for (int i = 0; i < sifre.Count; i++)
                    {
                        zakupacAutobusa.Add(new ZakupacAutobusa(sifre[i], imena[i], pocetak[i], kraj[i], cijene[i], Instanca.getDAO.getAutobusDAO().getById(sifreAutobusa[i])));
                    }
                    return zakupacAutobusa;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}

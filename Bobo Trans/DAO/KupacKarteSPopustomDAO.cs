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
        public class KupacKarteSPopustomDAO : IDaoCrud<KupacSaPopustom>
        {
            protected MySqlCommand c;

            public long create(KupacSaPopustom entity)
            {
                c = new MySqlCommand("START TRANSACTION;", con);
                long idKupca;
                try
                {
                    c = new MySqlCommand(String.Format("INSERT INTO kupcikarti VALUES ('','{0}','{1}');"
                         , entity.Ime, (int)(entity.TipKupca))
                         , con);
                    c.ExecuteNonQuery();
                    idKupca = c.LastInsertedId;

                    for (int i = 0; i < entity.Sjedista.Count; i++)
                    {
                        c = new MySqlCommand(String.Format("INSERT INTO karte VALUES ('','{0}','{1}','{2}','{3}','{4}','{5}');"
                         , entity.Voznja.SifraVoznje, entity.PocetnaStanica.SifraStanice, entity.KrajnjaStanica.SifraStanice, entity.Sjedista[i], entity.Cijene[i].ToString().Replace(',','.'), idKupca)
                         , con);
                        c.ExecuteNonQuery();
                    }

                    return idKupca;
                }
                catch (Exception e)
                {
                    c = new MySqlCommand("ROLLBACK;", con);
                    c.ExecuteNonQuery();
                    throw e;
                }
            }

            public KupacSaPopustom read(KupacSaPopustom entity)
            {
                int id;
                c = new MySqlCommand(string.Format("SELECT * FROM kupcikarti WHERE imeIPrezime='{0}' AND tipKupca='{1}'", entity.Ime, (int)(entity.TipKupca)), con);
                MySqlDataReader r = c.ExecuteReader();
                if (r.Read())
                {
                    id = r.GetInt32("id");
                    r.Close();
                }
                else
                {
                    r.Close();
                    throw new Exception("nije nadjen nijedan element");
                }
                return getById(id);
            }

            public KupacSaPopustom update(KupacSaPopustom entity)
            {
                delete(entity);
                entity.SifraKupca = create(entity);
                return entity;
            }

            public void delete(KupacSaPopustom entity)
            {
                try
                {
                    c = new MySqlCommand("START TRANSACTION;", con);
                    c.ExecuteNonQuery();

                    c = new MySqlCommand(string.Format("DELETE FROM karte WHERE idKupca='{0}'", entity.SifraKupca), con);
                    c.ExecuteNonQuery();

                    c = new MySqlCommand(string.Format("DELETE FROM kupcikarti WHERE id='{0}' AND tipKupca='{1}'", entity.SifraKupca, (int)(entity.TipKupca)), con);
                    c.ExecuteNonQuery();

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

            public KupacSaPopustom getById(long id)
            {
                long sifra = id;
                double popust;
                string ime;
                TipoviPodataka.TipoviKupaca tip;
                Stanica pocetnaStanica;
                Stanica krajnjaStanica;
                int pocetnaStanicaId=0;
                int krajnjaStanicaId=0;
                Voznja voznja;
                int voznjaId=0;
                List<int> sjedista = new List<int>();
                List<double> cijene = new List<double>();

                try
                {
                    c = new MySqlCommand("START TRANSACTION;", con);
                    c.ExecuteNonQuery();

                    ocitajImeITIp(id, out ime, out tip);

                    popust = ocitajPopust(tip);

                    ocitajKarte(id, ref pocetnaStanicaId, ref krajnjaStanicaId, ref voznjaId, sjedista, cijene);

                    pocetnaStanica = DAL.Instanca.getDAO.getStaniceDAO().getById(pocetnaStanicaId);
                    krajnjaStanica = DAL.Instanca.getDAO.getStaniceDAO().getById(krajnjaStanicaId);
                    voznja = DAL.Instanca.getDAO.getVoznjaDAO().getById(voznjaId);

                    c = new MySqlCommand("COMMIT;", con);
                    c.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    c = new MySqlCommand("ROLLBACK;", con);
                    c.ExecuteNonQuery();
                    throw e;
                }

                return new KupacSaPopustom((int)id, ime, pocetnaStanica, krajnjaStanica, voznja, sjedista, cijene, popust, "", tip);
            }

            private void ocitajKarte(long id, ref int pocetnaStanicaId, ref int krajnjaStanicaId, ref int voznjaId, List<int> sjedista, List<double> cijene)
            {
                pocetnaStanicaId = 0;
                krajnjaStanicaId = 0;
                voznjaId = 0;
                c = new MySqlCommand(string.Format("SELECT * FROM karte WHERE idKupca='{0}';", id), con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                {
                    pocetnaStanicaId = r.GetInt32("idPocetneStanice");
                    krajnjaStanicaId = r.GetInt32("idKrajnjeStanice");
                    voznjaId = r.GetInt32("idVoznje");
                    sjedista.Add(r.GetInt32("idSjedista"));
                    cijene.Add(r.GetDouble("cijena"));
                }

                r.Close();
            }

            private double ocitajPopust(TipoviPodataka.TipoviKupaca tip)
            {
                double popust;
                c = new MySqlCommand(string.Format("SELECT * FROM tipovikupacakarte WHERE id='{0}';", (int)(tip)), con);
                MySqlDataReader r = c.ExecuteReader();
                if (r.Read())
                {
                    popust = r.GetDouble("popust");
                    r.Close();
                }
                else
                {
                    r.Close();
                    throw new Exception("nije nadjen nijedan element");
                }
                return popust;
            }

            private void ocitajImeITIp(long id, out string ime, out TipoviPodataka.TipoviKupaca tip)
            {
                c = new MySqlCommand(string.Format("SELECT * FROM kupcikarti WHERE id='{0}' AND tipKupca<>'{1}';", id, (int)(TipoviPodataka.TipoviKupaca.BEZ_POPUSTA)), con);
                MySqlDataReader r = c.ExecuteReader();
                if (r.Read())
                {
                    ime = r.GetString("imeIPrezime");
                    tip = (TipoviPodataka.TipoviKupaca)(r.GetInt32("tipKupca"));
                    r.Close();
                }
                else
                {
                    r.Close();
                    throw new Exception("nije nadjen nijedan element");
                }
            }

            public List<KupacSaPopustom> GetAll()
            {
                List<KupacSaPopustom> kupci = new List<KupacSaPopustom>();
                c = new MySqlCommand(string.Format("SELECT id FROM kupcikarti WHERE tipKupca<>'{0}'", (int)(TipoviPodataka.TipoviKupaca.BEZ_POPUSTA)), con);
                MySqlDataReader r = c.ExecuteReader();
                List<long> sifre = new List<long>();
                while (r.Read())
                    sifre.Add(r.GetInt32("id"));
                r.Close();

                foreach (long sifra in sifre)
                    kupci.Add(getById(sifra));
                return kupci;
            }

            public List<KupacSaPopustom> getByExample(string name, string values)
            {
                throw new Exception("get by Example se ne moze implementirati za kupce karti");
            }
        }
    }
}

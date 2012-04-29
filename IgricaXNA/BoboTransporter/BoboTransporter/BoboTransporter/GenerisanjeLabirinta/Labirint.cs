using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoboTransporter.GenerisanjeLabirinta
{
    class Labirint
    {

        class Ivica
        {
            private int ax;

            public int Ax
            {
                get { return ax; }
                set { ax = value; }
            }
            private int ay;

            public int Ay
            {
                get { return ay; }
                set { ay = value; }
            }
            private int duzina;

            public int Duzina
            {
                get { return duzina; }
                set { duzina = value; }
            }

            private Ivica() { }
            public Ivica(int AX, int AY, int DUZINA)
            {
                ax = AX;
                ay = AY;
                duzina = DUZINA;
            }
            public static int sortiranjeIvica(Ivica a, Ivica b)
            {
                if (a.Duzina < b.Duzina) return 1;
                if (a.Duzina > b.Duzina) return -1;
                return 0;
            }
        }

        static private int sanseBlokade = 10;
        private Random rand;
        private int sirina;
        private int visina;
        private int ciljX;
        private int ciljY;

        public int CiljX
        {
            get { return ciljX; }
            set { ciljX = value; }
        }

        public int CiljY
        {
            get { return ciljY; }
            set { ciljY = value; }
        }

        public int Sirina
        {
            get { return sirina; }
        }
        public int Visina
        {
            get { return visina; }
        }

        /*
         * u ovim poljima ce cuvati podatke o poljima labirinta, i to su:
         * 0 - izlaz iz labirinta
         * 1 - raskrsnica
         * 2 - put je provodan
         * 3 - ne postoji put
         * 4 - nije put
         * 8 - nije provodan
         * 5 - nedefinisano
         * 6 - nedefinisano i nepogledano
         * 7 - raskrsnica kojoj nije moguce doci
         * unosi se X pa Y koordinata
        */
        private char[,] polje;

        public char[,] Polje
        {
            get { return polje; }
        }


        private Labirint() { }

        public Labirint(int _sirina, int _visina)
        {
            sirina = _sirina;
            visina = _visina;
            if (sirina < 1 || visina < 1) throw new Exception("Neodgovarajuce dimenzije");
            polje = new char[sirina * 2 + 1, visina * 2 + 1];
            rand = new Random();
        }

        private char dajBrojNeprolaznog()
        {
            bool bla = (rand.Next() % sanseBlokade == 0);
            if (bla) return '8';
            else return '3';
        }

        public void Generishi()
        {
            for (int i = 0; i < sirina * 2 + 1; i++)
            {
                for (int j = 0; j < visina * 2 + 1; j++)
                {
                    polje[i, j] = '4';
                }
            }
            for (int i = 1; i < sirina * 2; i++)
            {
                for (int j = 1; j < visina * 2; j++)
                {
                    polje[i, j] = '6';
                    if ((i % 2 == 1) && (j % 2 == 1)) polje[i, j] = '7';
                    if ((i % 2 == 0) && (j % 2 == 0)) polje[i, j] = '4';
                }
            }
            List<Ivica> ivice = new List<Ivica>();
            int slucajniBroj;
            int pozCiljX, pozCiljY;
            slucajniBroj = rand.Next();
            if (slucajniBroj % 4 == 0)
            {
                slucajniBroj = rand.Next();
                ciljX = 0;
                ciljY = (slucajniBroj % visina) * 2 + 1;
                pozCiljX = 1;
                pozCiljY = ciljY;
            }
            else if (slucajniBroj % 4 == 2)
            {
                slucajniBroj = rand.Next();
                ciljX = sirina * 2;
                ciljY = (slucajniBroj % visina) * 2 + 1;
                pozCiljX = sirina * 2 - 1;
                pozCiljY = ciljY;
            }
            else if (slucajniBroj % 4 == 1)
            {
                slucajniBroj = rand.Next();
                ciljX = (slucajniBroj % sirina) * 2 + 1;
                ciljY = 0;
                pozCiljX = ciljX;
                pozCiljY = 1;
            }
            else
            {
                ciljX = (slucajniBroj % sirina) * 2 + 1;
                ciljY = visina * 2;
                pozCiljX = ciljX;
                pozCiljY = visina * 2 - 1;
            }

            polje[ciljX, ciljY] = '0';
            polje[pozCiljX, pozCiljY] = '1';

            //dodaj susjede polja
            int trenutnoPoljeX = pozCiljX, trenutnoPoljeY = pozCiljY;

            dodajIvice(ivice, trenutnoPoljeX, trenutnoPoljeY);

            while (ivice.Count > 0)
            {
                ivice.Sort(Ivica.sortiranjeIvica);
                Ivica trenutna = ivice.First();
                ivice.Remove(trenutna);
                if (trenutna.Ax % 2 == 0)
                {
                    //horizontalna

                    if (polje[trenutna.Ax - 1, trenutna.Ay] == '7' || polje[trenutna.Ax + 1, trenutna.Ay] == '7')
                    {
                        polje[trenutna.Ax, trenutna.Ay] = '2';
                        polje[trenutna.Ax - 1, trenutna.Ay] = polje[trenutna.Ax + 1, trenutna.Ay] = '1';
                        //lijeva
                        trenutnoPoljeX = trenutna.Ax - 1;
                        trenutnoPoljeY = trenutna.Ay;
                        dodajIvice(ivice, trenutnoPoljeX, trenutnoPoljeY);


                        //desna
                        trenutnoPoljeX = trenutna.Ax + 1;
                        trenutnoPoljeY = trenutna.Ay;
                        dodajIvice(ivice, trenutnoPoljeX, trenutnoPoljeY);

                    }
                    else
                    {
                        polje[trenutna.Ax, trenutna.Ay] = dajBrojNeprolaznog();
                    }
                }
                else
                {
                    //vertikalna

                    if (polje[trenutna.Ax, trenutna.Ay - 1] == '7' || polje[trenutna.Ax, trenutna.Ay + 1] == '7')
                    {
                        polje[trenutna.Ax, trenutna.Ay] = '2';
                        polje[trenutna.Ax, trenutna.Ay - 1] = polje[trenutna.Ax, trenutna.Ay + 1] = '1';
                        //gornja
                        trenutnoPoljeX = trenutna.Ax;
                        trenutnoPoljeY = trenutna.Ay - 1;
                        dodajIvice(ivice, trenutnoPoljeX, trenutnoPoljeY);


                        //donja
                        trenutnoPoljeX = trenutna.Ax;
                        trenutnoPoljeY = trenutna.Ay + 1;
                        dodajIvice(ivice, trenutnoPoljeX, trenutnoPoljeY);

                    }
                    else
                    {
                        polje[trenutna.Ax, trenutna.Ay] = dajBrojNeprolaznog();
                    }
                }
            }

        }

        private void dodajIvice(List<Ivica> ivice, int trenutnoPoljeX, int trenutnoPoljeY)
        {
            if (polje[trenutnoPoljeX - 1, trenutnoPoljeY] == '6')
            {
                ivice.Add(new Ivica(trenutnoPoljeX - 1, trenutnoPoljeY, rand.Next()));
                polje[trenutnoPoljeX - 1, trenutnoPoljeY] = '5';
            }
            if (polje[trenutnoPoljeX + 1, trenutnoPoljeY] == '6')
            {
                ivice.Add(new Ivica(trenutnoPoljeX + 1, trenutnoPoljeY, rand.Next()));
                polje[trenutnoPoljeX + 1, trenutnoPoljeY] = '5';
            }
            if (polje[trenutnoPoljeX, trenutnoPoljeY - 1] == '6')
            {
                ivice.Add(new Ivica(trenutnoPoljeX, trenutnoPoljeY - 1, rand.Next()));
                polje[trenutnoPoljeX, trenutnoPoljeY - 1] = '5';
            }
            if (polje[trenutnoPoljeX, trenutnoPoljeY + 1] == '6')
            {
                ivice.Add(new Ivica(trenutnoPoljeX, trenutnoPoljeY + 1, rand.Next()));
                polje[trenutnoPoljeX, trenutnoPoljeY + 1] = '5';
            }
        }

        public void NacrtajUKonzoli()
        {

            for (int j = 0; j < visina * 2 + 1; j++)
            {
                for (int i = 0; i < sirina * 2 + 1; i++)
                {
                    switch (polje[i, j])
                    {
                        case '0': Console.Out.Write('X'); break;
                        case '1': Console.Out.Write('O'); break;
                        case '2': Console.Out.Write('0'); break;
                        case '3': Console.Out.Write(' '); break;
                        case '4': Console.Out.Write(' '); break;
                        case '5': Console.Out.Write("ERROR"); break;
                        case '6': Console.Out.Write("ERROR"); break;
                        case '7': Console.Out.Write("ERROR"); break;
                        case '8': Console.Out.Write(':'); break;

                    }
                }
                Console.WriteLine();
            }
        }

    }
}

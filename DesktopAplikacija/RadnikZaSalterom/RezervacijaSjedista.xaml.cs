using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopAplikacija.RadnikZaSalterom
{
    /// <summary>
    /// Interaction logic for RezervacijaSjedista.xaml
    /// </summary>
    public partial class RezervacijaSjedista : UserControl
    {
        Button[] sjedista;
        int[] stanjeSjedista;
        int brojSjedista;
        Button ado;
        public RezervacijaSjedista()
        {
            this.InitializeComponent();
            /*brojSjedista = 0;
            stanjeSjedista = new int[brojSjedista];
            for (int i = 0; i < brojSjedista; i++) stanjeSjedista[i] = 0;
            sjedista = new Button[brojSjedista];
            for (int i = 0; i < brojSjedista-5; i++)
            {
                sjedista[i] = new Button();
                sjedista[i].Content = (i + 1).ToString();
                sjedista[i].HorizontalAlignment = HorizontalAlignment.Left;
                sjedista[i].Margin = new Thickness(10+(i/4)*50, 10+(i%4)*70, 0, 0);
                sjedista[i].Name = String.Format("button{0}", i + 1);
                sjedista[i].VerticalAlignment = VerticalAlignment.Top;
                sjedista[i].Click += new RoutedEventHandler(IzaberiZauzece);
                myGrid.Children.Add(sjedista[i]);
                
            }

            for (int i = brojSjedista - 5; i < brojSjedista; i++)
            {
                sjedista[i] = new Button();
                sjedista[i].Content = (i + 1).ToString();
                sjedista[i].HorizontalAlignment = HorizontalAlignment.Left;
                sjedista[i].Margin = new Thickness(10 + (i / 4) * 50, 10 + (i + 5 - brojSjedista) * 70, 0, 0);
                sjedista[i].Name = String.Format("button{0}", i + 1);
                sjedista[i].VerticalAlignment = VerticalAlignment.Top;
                sjedista[i].Click += new RoutedEventHandler(IzaberiZauzece);
                myGrid.Children.Add(sjedista[i]);

            }*/
        }

        public RezervacijaSjedista(int brojSjedista_, List<bool> sjedisteZauzece, List<int> odabirSjedista)
        {
            this.InitializeComponent();
            brojSjedista=brojSjedista_;
            stanjeSjedista = new int[brojSjedista];
            for (int i = 0; i < brojSjedista; i++) stanjeSjedista[i] = 0;
            sjedista = new Button[brojSjedista];
            for (int i = 0; i < brojSjedista; i++) stanjeSjedista[i] = ((sjedisteZauzece[i]) ? 1 : 0);
            foreach (int mjest in odabirSjedista)
            {
                stanjeSjedista[mjest - 1] = 2;
            }
            for (int i = 0; i < brojSjedista - 5; i++)
            {
                sjedista[i] = new Button();
                sjedista[i].Content = (i + 1).ToString();
                sjedista[i].HorizontalAlignment = HorizontalAlignment.Left;
                sjedista[i].Margin = new Thickness(10 + (i / 4) * 50, 10 + (i%4+((i % 4)>1?1:0)) * 70, 0, 0);
                sjedista[i].Name = String.Format("button{0}", i + 1);
                sjedista[i].VerticalAlignment = VerticalAlignment.Top;
                sjedista[i].Click += new RoutedEventHandler(IzaberiZauzece);
                sjedista[i].Background = Brushes.LawnGreen;
                if (stanjeSjedista[i] == 1) sjedista[i].Background = Brushes.DarkRed;
                if (stanjeSjedista[i] == 2) sjedista[i].Background = Brushes.DarkOrange;
                myGrid.Children.Add(sjedista[i]);

            }
            int pozX = (brojSjedista - 5) / 4;
            for (int i = brojSjedista - 5; i < brojSjedista; i++)
            {
                sjedista[i] = new Button();
                sjedista[i].Content = (i + 1).ToString();
                sjedista[i].HorizontalAlignment = HorizontalAlignment.Left;
                sjedista[i].Margin = new Thickness(10 + pozX * 50, 10 + (i + 5 - brojSjedista) * 70, 0, 0);
                sjedista[i].Name = String.Format("button{0}", i + 1);
                sjedista[i].VerticalAlignment = VerticalAlignment.Top;
                sjedista[i].Click += new RoutedEventHandler(IzaberiZauzece);
                sjedista[i].Background = Brushes.LawnGreen;
                if (stanjeSjedista[i] == 1) sjedista[i].Background = Brushes.DarkRed;
                if (stanjeSjedista[i] == 2) sjedista[i].Background = Brushes.DarkOrange;
                myGrid.Children.Add(sjedista[i]);
            }
        }

        private void IzaberiZauzece(object sender, RoutedEventArgs e)
        {
            Button pritisnutoDugme = sender as Button;
            int brojDugmeta = Convert.ToInt32(pritisnutoDugme.Content)-1;
            if (stanjeSjedista[brojDugmeta]==0)//ako je slobodno, stavi na cekanje
            {
                stanjeSjedista[brojDugmeta] = 2;
                pritisnutoDugme.Background = Brushes.DarkOrange;
            }
            else if (stanjeSjedista[brojDugmeta] == 2)//ako je na cekanju, stavi da je slobodno
            {
                stanjeSjedista[brojDugmeta] = 0;
                pritisnutoDugme.Background = Brushes.LawnGreen;
            }
        }

        public List<int> trazenaMjesta()
        {
            List<int> tmp = new List<int>();
            for (int i = 0; i < brojSjedista; i++)
                if (stanjeSjedista[i] == 2) tmp.Add(i + 1);
            return tmp;
        }
    }
}

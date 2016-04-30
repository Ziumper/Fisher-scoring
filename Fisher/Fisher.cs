using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fisher
{
    public partial class Fisher : Form
    {
        SystemDecyzyjny system;

        public Fisher()
        {
            InitializeComponent();
            gBoxWyniki.Enabled = false;
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            var wczytaj = ofdDaneWczytaj.ShowDialog();
            if (wczytaj != DialogResult.OK) return;
            system = new SystemDecyzyjny(ofdDaneWczytaj.FileName);
            rtbPrzedSeleckja.Text = system.systemDeczyzyjnyTekst;
            tBLiczbaAtrybutów.Maximum = system.iloscAtrybutow;
            gBoxWyniki.Enabled = true;
           
        }

        private void btnWykonaj_Click(object sender, EventArgs e)
        {
            SystemDecyzyjny systemPrzed = new SystemDecyzyjny(ofdDaneWczytaj.FileName);
            List<KlasaCentralna> klasy = KlasaCentralna.GenerujKlasy(systemPrzed);//generowanie listy instancji klas
            foreach(KlasaCentralna klasa in klasy)
            {
                PoliczSeparacje(klasa);
                PosortujSeparacje(klasa);
                
                WyliczTabliceNumerówAtrybutów(klasa);
            }
            SystemDecyzyjny systemPo = new SystemDecyzyjny(klasy,tBLiczbaAtrybutów.Value);
            rtbPoSelekcji.Text = systemPo.systemDeczyzyjnyTekst;
        }

        private void PosortujSeparacje(KlasaCentralna klasa)
        {
            klasa.separacje.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
        }

        public static List<int> GenerujKlucze(List<KlasaCentralna> klasy, int value)
        {
            List<int> kluczeAtrybutow = new List<int>();
            for (int i = 0; i < value; i++)
            {
                foreach (KlasaCentralna klasa in klasy)
                {
                    if (!kluczeAtrybutow.Contains(klasa.tablicaNumerówAtrybutów[i]))
                    {
                        kluczeAtrybutow.Add(klasa.tablicaNumerówAtrybutów[i]);
                        if (kluczeAtrybutow.Count == value) break;
                    }
                }
                if (kluczeAtrybutow.Count == value) break;
            }
            return kluczeAtrybutow;
        }

        private void WyliczTabliceNumerówAtrybutów(KlasaCentralna klasa)
        {
            int licznik = 0;
            for(int i = klasa.separacje.Count-1; i >= 0; i--)
            {
                klasa.tablicaNumerówAtrybutów[licznik++] = klasa.separacje[i].Key;
            }
        }

        private void PoliczSeparacje(KlasaCentralna klasa)
        {
            Dictionary<int, double> separacje = new Dictionary<int, double>();
            for(int i = 0; i < klasa.iloscAtrybutow;i++)
            {
                separacje[i] = PoliczDlaAtrybutu(i, klasa.zbiórObiektów, klasa.obiektyZInnaDecyzja, klasa.cardC, klasa.cardU);
            }
            klasa.separacje = separacje.ToList();
        }

        private void PoliczSeparacjeDlaKlasy(int iloscAtrybutow,List<ObiektDecyzyjny> zbiórObiektów, List<ObiektDecyzyjny> obiektyZInnaDecyzja,Dictionary<int,double> separacje,int cardC,int cardU)
        {
            for(int i = 0; i < iloscAtrybutow;i++)
            {
                separacje[i] = PoliczDlaAtrybutu(i, zbiórObiektów, obiektyZInnaDecyzja, cardC, cardU);
            }
        }

        public static double PoliczDlaAtrybutu(int atrybut, List<ObiektDecyzyjny> zbiórObiektów, List<ObiektDecyzyjny> obiektyZInnaDecyzja, int cardC, int cardU)
        {
            double cZKreska = PoliczCzKreską(atrybut, zbiórObiektów, cardC);
            double cZDaszkiem = PolczCzDaszkiem(atrybut, zbiórObiektów, cardC, cardU, obiektyZInnaDecyzja);
            double zZKreska = PoliczZKreska(atrybut, zbiórObiektów, cardC,cZKreska);
            double zZDaszkiem = PoliczZzDaszkiem(atrybut, zbiórObiektów, cardC, cardU, obiektyZInnaDecyzja,cZDaszkiem);


            return (cZKreska - cZDaszkiem)*(cZKreska - cZDaszkiem)/(zZKreska + zZDaszkiem);
        }

        private static double PoliczZzDaszkiem(int key, List<ObiektDecyzyjny> zbiórObiektów, int cardC, int cardU, List<ObiektDecyzyjny> obiektyZInnaDecyzja, double cZDaszkiem)
        {
            double suma = 0;
            foreach (ObiektDecyzyjny obiekt in obiektyZInnaDecyzja)
                suma += (obiekt.atrybuty[key] - cZDaszkiem) * (obiekt.atrybuty[key] - cZDaszkiem);

            return suma/(cardU-cardC);
        }

        private static double PoliczZKreska(int key, List<ObiektDecyzyjny> zbiórObiektów, int cardC, double cZKreska)
        {
            double suma = 0;
            foreach (ObiektDecyzyjny obiekt in zbiórObiektów)
                suma += (obiekt.atrybuty[key] - cZKreska) * (obiekt.atrybuty[key] - cZKreska);
            return suma / cardC;
        }

        private static double PoliczCzKreską(int key, List<ObiektDecyzyjny> zbiórObiketów,int cardC)
        {
            double suma = 0;
            foreach(ObiektDecyzyjny obiekt in zbiórObiketów)
                suma += obiekt.atrybuty[key];
            
            return suma / cardC;
        }

        private static double PolczCzDaszkiem(int key, List<ObiektDecyzyjny> zbiórObiektów, int cardC, int cardU, List<ObiektDecyzyjny> obiektyZInnaDecyzja)
        {
            double suma = 0;
            foreach(ObiektDecyzyjny obiekt in obiektyZInnaDecyzja)
                suma += obiekt.atrybuty[key];
            
            return suma / (cardU - cardC);
        }

        private void tBLiczbaAtrybutów_Scroll(object sender, EventArgs e)
        {
            lbIloscAtrybutow.Text = tBLiczbaAtrybutów.Value.ToString();
        }
    }
}

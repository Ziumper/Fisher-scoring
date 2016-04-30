using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisher
{
    public class KlasaCentralna
    {
        public int iloscAtrybutow;
        public int decyzja;
        public int[] tablicaNumerówAtrybutów;
        public List<KeyValuePair<int,double>> separacje = new List<KeyValuePair<int, double>>();
        public List<ObiektDecyzyjny> zbiórObiektów = new List<ObiektDecyzyjny>();
        public List<ObiektDecyzyjny> obiektyZInnaDecyzja = new List<ObiektDecyzyjny>();
        public int cardC; //ilośc obiektów w danej klasie deczyjnej
        public int cardU; //ilośc obiektów w danym systemie decyzyjnym

        public KlasaCentralna(int decyzja,int iloscAtrybutow,List<ObiektDecyzyjny> zbiórObiektów)
        {
            cardU = zbiórObiektów.Count;
            foreach (ObiektDecyzyjny obiekt in zbiórObiektów)
            {
                if (decyzja == obiekt.decyzja) this.zbiórObiektów.Add(obiekt);
                else obiektyZInnaDecyzja.Add(obiekt);
            }
            cardC = this.zbiórObiektów.Count;
            this.decyzja = decyzja;
            this.iloscAtrybutow = iloscAtrybutow;
            tablicaNumerówAtrybutów = new int[iloscAtrybutow];
        }
        

        //STATIC !!!
        public static List<KlasaCentralna> GenerujKlasy(SystemDecyzyjny aSystem)
        {
            List<KlasaCentralna> klasyDecyzyjne = new List<KlasaCentralna>();
            foreach (int decyzja in aSystem.koncepty)
            {
                klasyDecyzyjne.Add(new KlasaCentralna(decyzja,aSystem.iloscAtrybutow, aSystem.zbiórObiektów));
            }
      
            return klasyDecyzyjne;
        }

        public static void DokonajSelekcji(KlasaCentralna klasa, List<int> kluczeAtrybutow)
        {
            foreach(ObiektDecyzyjny obiekt in klasa.zbiórObiektów)
            {
                ObiektDecyzyjny.DokonajSelekcjiDlaObiektu(obiekt, kluczeAtrybutow);
            }
        }
    }
}


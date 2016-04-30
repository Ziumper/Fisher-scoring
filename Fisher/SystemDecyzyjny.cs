using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisher
{
    public class SystemDecyzyjny
    {
      
      
        public List<ObiektDecyzyjny> zbiórObiektów = new List<ObiektDecyzyjny>();
        public List<int> koncepty = new List<int>();
        public int iloscAtrybutow;
        public string systemDeczyzyjnyTekst;
        

        public SystemDecyzyjny(string sciezkaDoPliku)
        {
            systemDeczyzyjnyTekst = System.IO.File.ReadAllText(sciezkaDoPliku);
            var daneZPliku = System.IO.File.ReadAllLines(sciezkaDoPliku);
            foreach (var wiersz in daneZPliku)
                if (wiersz.Trim() != "")
                    zbiórObiektów.Add(new ObiektDecyzyjny(wiersz));

            foreach (ObiektDecyzyjny obiekt in zbiórObiektów) {
                if (!koncepty.Contains(obiekt.decyzja)) koncepty.Add(obiekt.decyzja);
                iloscAtrybutow = obiekt.atrybuty.Count; 
            }
            koncepty.Sort();
            
            
        }  
    
        public SystemDecyzyjny(List<KlasaCentralna> klasy, int value) 
        {
            List<int> kluczeAtrybutow = Fisher.GenerujKlucze(klasy,value);
            WpiszObiektyDoSystemu(this, klasy, kluczeAtrybutow);
            iloscAtrybutow = value;
            foreach(KlasaCentralna k in klasy)
            {
                koncepty.Add(k.decyzja);
            }
            koncepty.Sort();
            systemDeczyzyjnyTekst = DopiszTekst(zbiórObiektów);
        }

        private string DopiszTekst(List<ObiektDecyzyjny> zbiórObiektów)
        {
            string napis = "";
            foreach(ObiektDecyzyjny o in zbiórObiektów)
               napis += ObiektDecyzyjny.DopiszWiersz(o) + o.decyzja + '\n';
            
            return napis;
        }

        private void WpiszObiektyDoSystemu(SystemDecyzyjny systemDecyzyjny, List<KlasaCentralna> klasy, List<int> kluczeAtrybutow)
        {
            foreach(KlasaCentralna k in klasy)
            {
               KlasaCentralna.DokonajSelekcji(k,kluczeAtrybutow);
               foreach(ObiektDecyzyjny obiekt in k.zbiórObiektów)
               {
                    systemDecyzyjny.zbiórObiektów.Add(obiekt);
               }
            }    
        }

        
    }
}

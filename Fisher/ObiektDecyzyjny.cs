using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisher
{
   public  class ObiektDecyzyjny
    {
        public Dictionary<int, int> atrybuty = new Dictionary<int, int>();
        public int decyzja;

        public ObiektDecyzyjny(string wiersz)
        {
            string[] miejsceParkingowe = wiersz.Split(' ');
            for (int i = 0; i < miejsceParkingowe.Length - 1; i++)
            {
                atrybuty[i] = int.Parse(miejsceParkingowe[i]);
            }
            decyzja = int.Parse(miejsceParkingowe.Last());
        }

        public static void DokonajSelekcjiDlaObiektu(ObiektDecyzyjny obiekt, List<int> kluczeAtrybutow)
        {
            Dictionary<int, int> atrybutyPoSelekcji = new Dictionary<int, int>();
            foreach (int klucz in kluczeAtrybutow)
            {
                atrybutyPoSelekcji[klucz] = obiekt.atrybuty[klucz];
            }
            obiekt.atrybuty = atrybutyPoSelekcji;
        }

        public static string DopiszWiersz(ObiektDecyzyjny o)
        {
            string wiersz = "";
            foreach(var a in o.atrybuty)
            {
                wiersz += a.Value.ToString() + ' ';
            }
            return wiersz;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Piwowar
{
    public class Styl
    {
        public string Nazwa {  get; set; }
        public string Kategoria { get; set; }

        public double ABV_min { get; set; }
        public double ABV_max { get; set; }

        public double BLG_min { get; set; }
        public double BLG_max { get; set; }

        public double EBC_min { get; set; }
        public double EBC_max { get; set; }

        public double IBU_min { get; set; }
        public double IBU_max { get; set; }
        public double FG_max { get; set; }
        public double FG_min { get; set; }

        public static string path = "Style.txt";
        public static List<Styl> ListaStylow = new List<Styl>();

        public Styl(string nazwa, string kategoria,  double aBV_min, double aBV_max, double bLG_min, double bLG_max, double fG_min, double fG_max, double eBC_min, double eBC_max, double iBU_min, double iBU_max)
        {
            Nazwa = nazwa;
            Kategoria = kategoria;

            ABV_min = aBV_min;
            ABV_max = aBV_max;
            BLG_min = bLG_min;
            BLG_max = bLG_max;
            EBC_min = eBC_min;
            EBC_max = eBC_max;
            IBU_min = iBU_min;
            IBU_max = iBU_max;
            FG_max = fG_max;
            FG_min = fG_min;
        }


        public static void Wczytaj_Z_Pliku()
        {

            if (File.Exists(path))
            {


                string[] linie = File.ReadAllLines(path);
                
                for(int i =1; i<linie.Length;i++)
                {
                    string[] elementy = linie[i].Split(';');
                    Styl styl = new(elementy[0], elementy[1], Convert.ToDouble(elementy[2]), Convert.ToDouble(elementy[3]), Convert.ToDouble(elementy[4]),
                        Convert.ToDouble(elementy[5]), Convert.ToDouble(elementy[6]), Convert.ToDouble(elementy[7]), Convert.ToDouble(elementy[8]), 
                        Convert.ToDouble(elementy[9]), Convert.ToDouble(elementy[10]), Convert.ToDouble(elementy[11]));
                    ListaStylow.Add(styl);

                }

            }
            else
            {
                Debug.WriteLine("Plik " + path + " Nie istnieje");
            }
        }
    }
}

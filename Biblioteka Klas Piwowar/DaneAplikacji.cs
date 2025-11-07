using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Klas_Piwowar
{
    /// <summary>
    /// Zawierająca wszystkie informacje, dane ogólno-aplikacyjne
    /// </summary>
    public static class DaneAplikacji
    {
        public static double Straty_Chlodzenie {  get; set; } 
        public static double Straty_Fermentator { get; set; }
        public static double Straty_Ogolem { get; set; }
        public static string path = "Dane_Aplikacji \n";


        /// <summary>
        /// Funkcja zapisująca wszystkie informacje ogólno aplikacyjne wszczególności straty
        /// </summary>
        public static void Zapisz()
        {
            
            string do_zapisu = "Straty z Chlodzenia;"+Straty_Chlodzenie+ "\n Straty w Fermentatorze:"+Straty_Fermentator+"\n Straty Ogolem;"+Straty_Ogolem;
            if (File.Exists(path))
            {
                File.WriteAllText(path, do_zapisu);
            }
            else
            {
                Debug.WriteLine("Plik" + path + "Nie istenieje");
            }
        }
        /// <summary>
        /// Wczytuje wszystkie informacje ogólno aplikacyjne
        /// </summary>
        public static void Wczytaj()
        {
            if (File.Exists(path))
            {
                List<string > list = new List<string>();
                string [] linie =File.ReadAllLines(path);
                foreach (string i in linie)
                {
                    string[] elementy = i.Split(';');
                    list.Add(elementy[1]);

                }
                Straty_Chlodzenie = Convert.ToDouble(list[0]);
                Straty_Fermentator = Convert.ToDouble(list[1]);
                Straty_Ogolem = Convert.ToDouble(list[1]);

            }
            else
            {
                Debug.WriteLine("Plik" + path + "Nie istenieje");
            }

        }
    }
}

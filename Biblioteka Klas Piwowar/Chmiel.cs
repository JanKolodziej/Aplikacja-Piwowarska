using System.Diagnostics;

namespace Biblioteka_Klas_Piwowar
{ 
    /// <summary>
    /// 
    /// </summary>
    public class Chmiel
    {
        public string Nazwa { get; set; }
        public double AlfaKwasy { get; set; }
        public static List<Chmiel> ListaChmieli = new();
        public static string path = "Chmiel.txt";

        public Chmiel(string nazwa, double alfa)
        {
            Nazwa = nazwa;
            AlfaKwasy = alfa;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void WczytajChmiel()
        {

            if (File.Exists(path))
            {


                string[] linie = File.ReadAllLines(path);
                foreach (string i in linie)
                {
                    string[] elementy = i.Split(';');
                    Chmiel chmiel = new(elementy[0], Convert.ToDouble(elementy[1]));
                    ListaChmieli.Add(chmiel);

                }

            }
            else
            {
                Debug.WriteLine("Plik " + path + " Nie istnieje");
            }

        }
    }
}

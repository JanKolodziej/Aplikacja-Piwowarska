using System.Diagnostics;

namespace Biblioteka_Klas_Piwowar
{
    /// <summary>
    /// Przechowuje dane o słodzie
    /// </summary>
    public class Slod
    {
        public double EBC { get; set; }
        public string Nazwa { get; set; }
        public double Wydajnosc { get; set; }

        static public readonly string path = "Slody_csharp.txt";
        public double Fermentowalnosc { get; set; }

        public static List<Slod> ListaSlodow { get; set; } = new();
        public Slod(string nazwa, double ebc = 1, double wydajnosc = 75, double fermentowalnosc = 75)
        {
            Nazwa = nazwa;
            EBC = ebc;
            Wydajnosc = wydajnosc;
            Fermentowalnosc = fermentowalnosc;
        }
       /// <summary>
       /// Wczytuje dane z pliku
       /// </summary>
        public static void WczytajSlod()
        {

            if (File.Exists(path))
            {


                string[] linie = File.ReadAllLines(path);
                foreach (string i in linie)
                {
                    string[] elementy = i.Split(';');
                    if(elementy.Length <4)
                    {
                        continue;
                    }
                    Slod slod = new(elementy[0], 
                        Convert.ToDouble(elementy[1]), 
                        Convert.ToDouble(elementy[2]), 
                        Convert.ToDouble(elementy[3]));
                    ListaSlodow.Add(slod);

                }

            }
            else
            {
                Debug.WriteLine("Plik " + path + " Nie istnieje");
            }

        }



    }
}

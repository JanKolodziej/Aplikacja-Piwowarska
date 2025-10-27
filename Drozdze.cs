using System.Diagnostics;

namespace Projekt_Piwowar
{
    public class Drozdze
    {
        public int Odfermentowanie { get; set; }
        public string Nazwa { get; set; }
        static string path = "Drozdze.txt";
        public static List<Drozdze> ListaDrozdzy { get; set; } = new();
        public Drozdze(string nazwa, int od)
        {
            Nazwa = nazwa;
            Odfermentowanie = od;
        }


        public static void WczytajDrozdze()
        {

            if (File.Exists(path))
            {


                string[] linie = File.ReadAllLines(path);
                foreach (string i in linie)
                {
                    string[] elementy = i.Split(';');
                    Drozdze drozdze = new(elementy[0], Convert.ToInt32(elementy[1]));
                    ListaDrozdzy.Add(drozdze);

                }

            }
            else
            {
                Debug.WriteLine("Plik " + path + " Nie istnieje");
            }

        }
    }
}





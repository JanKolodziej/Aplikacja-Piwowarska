using System.Diagnostics;

namespace Projekt_Piwowar
{
    /// <summary>
    /// Slod z waga i cena
    /// </summary>
    public class Slod_uzytkownika
    {
        public double Waga { get; set; }
        public double Cena { get; set; }

        public Slod Slod { get; set; }
        static string path = "Slody_Uzytkownika.txt";
        public static List<Slod_uzytkownika> ListaSlodowUzytkownika { get; set; } = new();


        public Slod_uzytkownika(double waga, double cena, Slod slod)
        {
            Waga = waga;
            Cena = cena;
            Slod = slod;
        }
        /// <summary>
        /// Wczytuje z pliku
        /// </summary>
        public static void WczytajSlodUzytkownika()
        {
            if (File.Exists(path))
            {
                string[] linie = File.ReadAllLines(path);
                foreach (string i in linie)
                {
                    string[] elementy = i.Split(';');
                    foreach (Slod slod_z_bazy in Slod.ListaSlodow)
                    {
                        if (slod_z_bazy.Nazwa == elementy[0])
                        {
                            Slod_uzytkownika slod_uzytkownika = new(Convert.ToDouble(elementy[1]), Convert.ToDouble(elementy[2]), slod_z_bazy);
                            ListaSlodowUzytkownika.Add(slod_uzytkownika);

                        }
                    }

                }
            }
            else
            {
                Debug.WriteLine("Plik" + path + "Nie istnieje");
            }

        }

        /// <summary>
        /// Zapisuje do pliku
        /// </summary>
        public static void Zmien_wartosci_w_pliku()
        {
            string[] do_zapisu = new string[ListaSlodowUzytkownika.Count];
            for (int i = 0; i < ListaSlodowUzytkownika.Count; i++)
            {
                do_zapisu[i] = ListaSlodowUzytkownika[i].Slod.Nazwa + ";" + ListaSlodowUzytkownika[i].Waga + ";" + ListaSlodowUzytkownika[i].Cena;

            }
            if (File.Exists(path))
            {
                File.WriteAllLines(path, do_zapisu);
            }
            else
            {
                Debug.WriteLine("Plik" + path + "Nie isteniej");
            }


        }
       
    }
}

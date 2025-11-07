
using System.Diagnostics;

namespace Biblioteka_Klas_Piwowar
{
    public class Drozdze_uzytkownika
    {
        static string path = "Drozdze_uzytkownika.txt";
        public static List<Drozdze_uzytkownika> ListaDrozdzyUzytkownika { get; set; } = new();
        public double Waga { get; set; }
        public double Cena { get; set; }
        public Drozdze Drozdze { get; set; }

        public Drozdze_uzytkownika(double waga, double cena, Drozdze drozdze)
        {
            Drozdze = drozdze;
            Waga = waga;
            Cena = cena;
        }

        public static void WczytajDrodzdzeUzytkownika()
        {
            if (File.Exists(path))
            {
                string[] linie = File.ReadAllLines(path);
                foreach (string i in linie)
                {
                    string[] elementy = i.Split(';');
                    foreach (Drozdze drozdze_z_bazy in Drozdze.ListaDrozdzy)
                    {
                        if (drozdze_z_bazy.Nazwa == elementy[0])
                        {
                            Drozdze_uzytkownika drozdze_uzytkownika = new(Convert.ToDouble(elementy[1]), Convert.ToDouble(elementy[2]), drozdze_z_bazy);
                            ListaDrozdzyUzytkownika.Add(drozdze_uzytkownika);

                        }
                    }

                }
            }
            else
            {
                Debug.WriteLine("Plik" + path + "Nie istnieje");
            }

        }


        public static void Zmien_wartosci_w_pliku()
        {
            string[] do_zapisu = new string[ListaDrozdzyUzytkownika.Count];
            for (int i = 0; i < ListaDrozdzyUzytkownika.Count; i++)
            {
                do_zapisu[i] = ListaDrozdzyUzytkownika[i].Drozdze.Nazwa + ";" + ListaDrozdzyUzytkownika[i].Waga + ";" + ListaDrozdzyUzytkownika[i].Cena;

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

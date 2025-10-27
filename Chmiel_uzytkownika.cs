using System.Diagnostics;

namespace Projekt_Piwowar
{
    public enum RodzajChmielenia
    {
        Gotowanie,
        ChmielNaZimno,
        HopStand
    }
    public class Chmiel_uzytkownika
    {
        public double Waga { get; set; }
        public double Cena { get; set; }
        public Chmiel Chmiel { get; set; }
        public static List<Chmiel_uzytkownika> ListaChmieluUzytkownika { get; set; } = new();
        public static string path = "Chmiel_uzytkownika.txt";


        //Czesc używana do receptur/warek
        public RodzajChmielenia Chmielenie {  get; set; }
        public int Czas {  get; set; }
        public int Dni {  get; set; }
        //*************

        public Chmiel_uzytkownika(double waga, double cena, Chmiel chmiel)
        {
            Waga = waga;
            Cena = cena;
            Chmiel = chmiel;
        }

        public static void WczytajChmielUzytkownika()
        {
            if (File.Exists(path))
            {
                string[] linie = File.ReadAllLines(path);
                foreach (string i in linie)
                {
                    string[] elementy = i.Split(';');
                    foreach (Chmiel chmiel_z_bazy in Chmiel.ListaChmieli)
                    {
                        if (chmiel_z_bazy.Nazwa == elementy[0])
                        {
                            Chmiel_uzytkownika chmiel_uzytkownika = new(Convert.ToDouble(elementy[1]), Convert.ToDouble(elementy[2]), chmiel_z_bazy);
                            ListaChmieluUzytkownika.Add(chmiel_uzytkownika);

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
            string[] do_zapisu = new string[ListaChmieluUzytkownika.Count];
            for (int i = 0; i < ListaChmieluUzytkownika.Count; i++)
            {
                do_zapisu[i] = ListaChmieluUzytkownika[i].Chmiel.Nazwa + ";" + ListaChmieluUzytkownika[i].Waga + ";" + ListaChmieluUzytkownika[i].Cena;

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

using System.Diagnostics;

namespace Biblioteka_Klas_Piwowar
{
    public class Receptura
    {
        public List<Slod_uzytkownika> ListaSlodowReceptura = new();
        public static string path = "Receptury.txt";

        public List<Chmiel_uzytkownika> ListaChmieluReceptura = new();
       

        public string Nazwa { get; set; }
        public string Styl { get; set; }
        public double Alkohol { get; set; }
        public double BLG { get; set; }
        public double IBU { get; set; }
        public double EBC { get; set; }
        public double Wydajnosc { get; set; }
        public double Objetosc { get; set; }
        public double Straty { get; set; }
        public Drozdze_uzytkownika Drozdze_Receptura { get; set; }
        public double Final_BLG { get; set; }



        public static List<Receptura> ListaReceptur = new();

        public double Policz_EBC()
        {
            double wynik = 0.0D;
            foreach (Slod_uzytkownika element in ListaSlodowReceptura)
            {
                wynik = wynik + element.Waga * element.Slod.EBC;
            }


            return wynik * 17.0 / Objetosc;

        }
        public double Policz_BLG()
        {
            double wynik = 0.0D;
            foreach (Slod_uzytkownika element in ListaSlodowReceptura)
            {
                wynik = wynik + element.Slod.Wydajnosc * element.Waga / 100;
            }
            return wynik * Wydajnosc * 100 / (100 * (Objetosc + Straty));
        }

        public static double BlgToGravity(double blg)
        {
            return 1 + blg / (258.6 - blg / 258.2 * 227.1);
        }


        public Receptura(string nazwa, string styl, List<Chmiel_uzytkownika> Lchmiel, List<Slod_uzytkownika> Lslod, double obj, double wyd, double str, double blg, double ibu, double ebc, Drozdze_uzytkownika drozdze, double alkohol,double fg)
        {
            Nazwa = nazwa;
            Styl = styl;
            ListaChmieluReceptura = Lchmiel;
            ListaSlodowReceptura = Lslod;
           
            Objetosc = obj; ;
            Straty = str;
            Wydajnosc = wyd;
            BLG = blg;
            EBC = ebc;
            IBU = ibu;
            Drozdze_Receptura = drozdze;
            Alkohol = alkohol;
            Final_BLG = fg;

        }
        public void Zapisz_Recepture()//kolejnosc zapisu naza;styl;słody;Chmiel z czasem;
        {

            string[] do_zapisu = new string[ListaReceptur.Count];
            for (int i = 0; i < ListaReceptur.Count; i++)
            {

              do_zapisu[i]= ListaReceptur[i].Receptura_ToString();


            }
            if (File.Exists(path))
            {
                File.WriteAllLines(path, do_zapisu);
            }
            else
            {
                Debug.WriteLine("Plik" + path + "Nie istnieje");
            }


        }
        public string Receptura_ToString() //Funkcja powstała aby można było zapisać użytą recepture w zapisie Warki a przy okazji w zapisie samych receptur
        {
            string do_zapisu = "";
            do_zapisu += do_zapisu + Nazwa + ";" + Styl + ";";
            int liczba_slodow = ListaSlodowReceptura.Count; //Liczba slodow w recepturze
            do_zapisu += liczba_slodow + ";";

            for (int j = 0; j < liczba_slodow; j++) //Zapis wszystkich slodow nazwa;waga;
            {
                do_zapisu += ListaSlodowReceptura[j].Slod.Nazwa + ";" + ListaSlodowReceptura[j].Waga + ";";
            }
            int liczba_chmieli = ListaChmieluReceptura.Count; //Liczba chmielu w recepturze

            do_zapisu += liczba_chmieli + ";";
            for (int j = 0; j < liczba_chmieli; j++) //Zapis wszystkich chmieli nazwa;waga;czas;
            {
                do_zapisu += ListaChmieluReceptura[j].Chmiel.Nazwa + ";" + ListaChmieluReceptura[j].Waga + ";" + ListaChmieluReceptura[j].Chmielenie + ";"+ (ListaChmieluReceptura[j].Chmielenie ==RodzajChmielenia.ChmielNaZimno ? ListaChmieluReceptura[j].Dni: ListaChmieluReceptura[j].Czas)+";";
            }

            do_zapisu += Drozdze_Receptura.Drozdze.Nazwa + ";" + Drozdze_Receptura.Waga + ";" + Objetosc + ";" + Wydajnosc + ";" + Straty + ";" + BLG + ";";
            do_zapisu += IBU + ";" + EBC + ";" + Alkohol + ";" + Final_BLG;
            return do_zapisu;
        }

        public static void Wczytaj_Z_Pliku()
        {
            if (File.Exists(path))
            {


                string[] linie = File.ReadAllLines(path);
                
                foreach (string i in linie)
                {
                    
                    ListaReceptur.Add(File_ToReceptura(i));

                }

            }
            else
            {
                Debug.WriteLine("Plik " + path + " Nie istnieje");
            }
        } 
        //Ta funkcja również powstała do obsługi klasy Warka
        public static Receptura File_ToReceptura(string i)
        {
            int wsk = 0;
            int j = 0;
            string[] elementy = i.Split(';');
            List<Slod_uzytkownika> lista_slodow = new();
            for (j = 0; j < Convert.ToInt32(elementy[2]); j++)
            {
                foreach (Slod slod in Slod.ListaSlodow)
                {
                    if (slod.Nazwa == elementy[3 + 2 * j])
                    {
                        Slod_uzytkownika slod_Uzytkownika = new(Convert.ToDouble(elementy[4 + 2 * j]), 0, slod);
                        lista_slodow.Add(slod_Uzytkownika);
                    }
                }

            }
            wsk = 4 + 2 * (j - 1) + 1; //Wskaźnik w tym momencie ustawiony na ilosci chmielu
            Debug.WriteLine(1);
            List<Chmiel_uzytkownika> chmiel_Uzytkownikas = new();
            

            for (j = 0; j < Convert.ToInt32(elementy[wsk]); j++)
            {
                foreach (Chmiel chmiel in Chmiel.ListaChmieli)
                {
                    if (chmiel.Nazwa == elementy[wsk + 1 + 4 * j])
                    {
                        Chmiel_uzytkownika chmiel_u = new(Convert.ToDouble(elementy[wsk + 2 + 4 * j]), 0, chmiel);
                        chmiel_u.Chmielenie = Enum.Parse <RodzajChmielenia> (elementy[wsk + 3 + 4 * j]);
                        if(chmiel_u.Chmielenie == RodzajChmielenia.ChmielNaZimno)
                        {
                            chmiel_u.Dni = Convert.ToInt32(elementy[wsk + 4 + 4 * j]);
                        }
                        else
                        {
                            chmiel_u.Czas = Convert.ToInt32(elementy[wsk + 4 + 4 * j]);
                        }
                        chmiel_Uzytkownikas.Add(chmiel_u);
                        
                    }
                }

            }
            Debug.WriteLine(1);
            wsk = wsk + 4 + 4 * (j - 1) + 1; //Wskaźnik ustawiony na drozdzach
            Debug.WriteLine(elementy[wsk]);
            foreach (Drozdze drozdze1 in Drozdze.ListaDrozdzy)
            {
                Debug.WriteLine(2);
                if (drozdze1.Nazwa == elementy[wsk])
                {
                    Debug.WriteLine(3);
                    Drozdze_uzytkownika drozdze_u = new(Convert.ToDouble(elementy[++wsk]), 0, drozdze1);
                    wsk++;//Teraz wskaźnik ustawiony na objetosc


                    Receptura receptura = new(elementy[0], elementy[1], chmiel_Uzytkownikas, lista_slodow, 
                    Convert.ToDouble(elementy[wsk]), Convert.ToDouble(elementy[wsk + 1]), Convert.ToDouble(elementy[wsk + 2]), Convert.ToDouble(elementy[wsk + 3]),
                    Convert.ToDouble(elementy[wsk + 4]), Convert.ToDouble(elementy[wsk + 5]), drozdze_u, Convert.ToDouble(elementy[wsk + 6]), Convert.ToDouble(elementy[wsk + 7]));


                    return receptura;
                }

            }
            throw new Exception("Coś poszło nie tak przy wczytywaniu receptury");
        }


    }
}

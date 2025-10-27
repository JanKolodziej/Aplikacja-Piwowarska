using System.Diagnostics;

namespace Projekt_Piwowar
{
    public enum EtapWarki
    {
        Planowanie,
        Warzenie,
        Fermentacja,
        Nagazowanie,
        Gotowe,
        Zarchiwizowane
    }
    public class Warka
    {
        public static string path = "Warki.txt";
        public Receptura receptura { get; set; }
        public string Nazwa { get; set; }
        public int NumerWarki { get; set; }
        public double FaktBLG { get; set; }
        public double FaktABV { get; set; }
        public double FaktOG { get; set; }
        public double FaktOBJ { get; set; }
        public double FaktWydajnosc { get; set; }
        public EtapWarki Etap {  get; set; }
        public bool Czy_Pobrano_Materialy { get; set; }
        public bool Czy_Na_minus {  get; set; }


        

        //Daty do kalendarza***********************
        public DateOnly DataWarzenia { get; set; }
        public DateOnly DataCichej {  get; set; }
        public DateOnly DataLezakowania { get; set; }
        public DateOnly DataButelkowania { get; set; }
        public DateOnly DataGotowe { get; set; }
        
        //*****************************************

        public static List<Warka> ListaWarek = new();

        public Warka(Receptura rec,string naz, int nr, DateOnly dw, DateOnly db, DateOnly dg, DateOnly dc, DateOnly dl, double faktblg = 0, double faktabv = 0, double faktOg = 0, double faktobj = 0, double faktwyd = 0, EtapWarki etap = EtapWarki.Planowanie, bool czy_Pobrano_Materialy = false, bool czy_Na_minus = false)
        {
            receptura = rec;
            Nazwa = naz;
            DataWarzenia = dw;
            DataButelkowania = db;
            DataGotowe = dg;
            DataCichej = dc;
            DataLezakowania = dl;
            NumerWarki = nr;
            FaktBLG = faktblg;
            FaktABV = faktabv;
            FaktOG = faktOg;
            FaktOBJ = faktobj;
            FaktWydajnosc = faktwyd;
            Etap = etap;
            Czy_Pobrano_Materialy = czy_Pobrano_Materialy;
            Czy_Na_minus = czy_Na_minus;
        }

        public static void Aktualizacja_Etapu()
        {
            foreach(Warka warka in ListaWarek)
            {
                if(warka.Etap==EtapWarki.Zarchiwizowane)
                {
                    break;
                }
                else
                {
                    if(warka.Etap == EtapWarki.Planowanie && warka.DataWarzenia<DateOnly.FromDateTime(DateTime.Now))
                    {
                        Aktualiacja_etapu aktualiacja_Etapu = new(warka);
                        aktualiacja_Etapu.ShowDialog();
                        if(aktualiacja_Etapu.DialogResult==DialogResult.Yes)
                        {
                            warka.Etap = EtapWarki.Fermentacja;
                        }
                        
                        
                    }
                    else if (warka.Etap == EtapWarki.Fermentacja && warka.DataButelkowania < DateOnly.FromDateTime(DateTime.Now))
                    {
                        Aktualiacja_etapu aktualiacja_Etapu = new(warka);
                        aktualiacja_Etapu.ShowDialog();
                        if (aktualiacja_Etapu.DialogResult == DialogResult.Yes)
                        {
                            warka.Etap = EtapWarki.Nagazowanie;
                        }
                    }
                    else if (warka.Etap == EtapWarki.Nagazowanie && warka.DataGotowe < DateOnly.FromDateTime(DateTime.Now))
                    {
                        Aktualiacja_etapu aktualiacja_Etapu = new(warka);
                        aktualiacja_Etapu.ShowDialog();
                        if (aktualiacja_Etapu.DialogResult == DialogResult.Yes)
                        {
                            warka.Etap = EtapWarki.Gotowe;
                        }
                    }
                }

            }
            Warka.Zapisz();
        }



        public static void Zapisz()
        {
            string[] do_zapisu = new string[ListaWarek.Count];
            int i = 0;
            foreach(Warka w in ListaWarek)
            {
                do_zapisu[i] = w.receptura.Receptura_ToString() + "|" +w.Nazwa+";" +w.NumerWarki.ToString() + ";" + w.DataWarzenia.ToString("yyyy-MM-dd") + ";" + w.DataButelkowania.ToString("yyyy-MM-dd") + ";";
                do_zapisu[i] += w.DataGotowe.ToString("yyyy-MM-dd") + ";" + w.DataCichej.ToString("yyyy-MM-dd") + ";" + w.DataLezakowania.ToString("yyyy-MM-dd") + ";";
                do_zapisu[i] += w.FaktBLG + ";" + w.FaktABV + ";" + w.FaktOG + ";" + w.FaktOBJ + ";" + w.FaktWydajnosc+";"+w.Etap+";"+w.Czy_Pobrano_Materialy+";"+w.Czy_Na_minus;
                i++;
            }


            if(File.Exists(path))
            {
                File.WriteAllLines(path, do_zapisu);
            }
            else
            {
                Debug.WriteLine("Plik " + path + " nie istnieje");
            }
        }
        public static void Wczytaj_Z_Pliku()
        {
            
            if(File.Exists(path))
            {
                string[] linie = File.ReadAllLines(path);
                foreach(string i in linie)
                {
                    string[] rozdzielenie = i.Split('|'); //W pliku receptura | parametry warki
                    string[] elementy = rozdzielenie[1].Split(";");
                    Warka warka = new(Receptura.File_ToReceptura( rozdzielenie[0]),elementy[0], Convert.ToInt32(elementy[1]), DateOnly.ParseExact(elementy[2], "yyyy-MM-dd"),
                        DateOnly.ParseExact(elementy[3], "yyyy-MM-dd"), DateOnly.ParseExact(elementy[4], "yyyy-MM-dd"), DateOnly.ParseExact(elementy[5], "yyyy-MM-dd"),DateOnly.ParseExact(elementy[6], "yyyy-MM-dd"), 
                        Convert.ToDouble(elementy[7]),Convert.ToDouble(elementy[8]), Convert.ToDouble(elementy[9]), Convert.ToDouble(elementy[10]), Convert.ToDouble(elementy[11]), 
                        Enum.Parse < EtapWarki >(elementy[12]), Convert.ToBoolean(elementy[13]), Convert.ToBoolean(elementy[14]));
                    ListaWarek.Add(warka);

                }
                
            }
            else
            {
                Debug.WriteLine("Plik " + path + " nie istnieje");
            }
        }
    }
}

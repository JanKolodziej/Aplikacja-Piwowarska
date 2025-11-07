using Biblioteka_Klas_Piwowar;
namespace Projekt_Piwowar
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            DaneAplikacji.Wczytaj();
            Slod.WczytajSlod();
            Chmiel.WczytajChmiel();
            Drozdze.WczytajDrozdze();

            Slod_uzytkownika.WczytajSlodUzytkownika();
            Chmiel_uzytkownika.WczytajChmielUzytkownika();
            Drozdze_uzytkownika.WczytajDrodzdzeUzytkownika();

            Receptura.Wczytaj_Z_Pliku();
            Warka.Wczytaj_Z_Pliku();
            Styl.Wczytaj_Z_Pliku();
            

            
            ApplicationConfiguration.Initialize();
            Application.ThreadException += (sender, args) =>
            {
                MessageBox.Show("Wyst¹pi³ b³¹d: " + args.Exception.Message + "\n" + args.Exception.StackTrace);
            };
            Application.Run(new Form_Magazyn());




        }
    }
}
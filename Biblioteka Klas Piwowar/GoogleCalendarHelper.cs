using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace Biblioteka_Klas_Piwowar
{
    

    public class GoogleCalendarHelper
    {
        private static string[] Scopes = { CalendarService.Scope.Calendar };
        private static string ApplicationName = "Projekt Piwowar";

        public static void DodajWydarzenie(string tytul, string opis, DateOnly start)
        {
            UserCredential credential;

            using (var stream =
                   new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json"; // plik do zapisywania tokenu użytkownika
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            // Inicjalizacja API
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Tworzymy wydarzenie
            Event newEvent = new Event()
            {
                Summary = tytul,
                Description = opis,
                Start = new EventDateTime()
                {
                    Date = start.ToString("yyyy-MM-dd"),
                    TimeZone = "Europe/Warsaw",
                },
                End = new EventDateTime()
                {
                    Date = start.AddDays(1).ToString("yyyy-MM-dd"),
                    TimeZone = "Europe/Warsaw",
                },
                Reminders = new Event.RemindersData()
                {
                    UseDefault = false,
                    Overrides = new EventReminder[]
                    {
                    
                    new EventReminder() { Method = "email", Minutes = 24*60 } // dzień wcześniej
                    }
                },
                ColorId = "5"
            };


            // Wysyłamy do kalendarza
            EventsResource.InsertRequest request = service.Events.Insert(newEvent, "primary");
            Event createdEvent = request.Execute();

            Debug.WriteLine("Dodano wydarzenie: " + createdEvent.HtmlLink);
        }
    }
}

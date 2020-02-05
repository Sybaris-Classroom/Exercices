using Common;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace PersonReader.Service
{
    // TODO 1 : Implementer le design pattern Repository pattern. Cela va découpler la couche "03-Data Access" de la couche "02-Presentation"
    // TODO 1-1 : Click droit sur le nom de la classe (ServiceReader) et sélectionez "Quick action and Refactoring..." then "Extract Interface"
    // TODO 1-2 : Nommer l'interface IRepository et laisser les autres valeur par défaut
    public class ServiceReader : IRepository
    {
        WebClient client;
        string baseUri;

        public ServiceReader()
        {
            client = new WebClient();
            baseUri = "http://localhost:9874";
        }

        public IReadOnlyCollection<Person> GetPeople()
        {
            var address = $"{baseUri}/people";
            string reply = client.DownloadString(address);
            return JsonConvert.DeserializeObject<IReadOnlyCollection<Person>>(reply);
        }

        public Person GetPerson(int id)
        {
            var address = $"{baseUri}/people/{id}";
            string reply = client.DownloadString(address);
            return JsonConvert.DeserializeObject<Person>(reply);
        }
    }

    // TODO 4 : Faire en sorte que l'application utilise un repository csv
    // TODO 4-1 : Inclure le projet PersonReader.CSV sous le dossier "03-Data Access" (Add/Existing project)

    // TODO 5 : Implémenter un système de cache
    // TODO 5-1 : Inclure le projet PersonReader.Caching sous le dossier "03-Data Access" (Add/Existing project)

    // TODO 6 : Implémenter des tests unitaires PeopleViewer.Presentation.Tests
    // TODO 6-1 : Inclure le projet PeopleViewer.Presentation.Tests sous le dossier "01-View"  (Add/Existing project)

    // TODO 7 : Implémenter des tests unitaires PeopleViewer.CSV.Tests
    // TODO 7-1 : Inclure le projet PersonReader.CSV.Tests sous le dossier "03-Data Access"  (Add/Existing project)

}

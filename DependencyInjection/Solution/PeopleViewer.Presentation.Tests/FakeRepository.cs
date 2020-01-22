using Common;
using PersonReader.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleViewer.Presentation.Tests
{

    // TODO 6-2 : Décommenter le code suivant
    // TODO 6-3 : Faire en sorte que la classe FakeRepository implémente l'interface IRepository

    public class FakeRepository : IRepository
    {

        public IReadOnlyCollection<Person> GetPeople()
        {
            var people = new List<Person>()
            {
                new Person() {Id = 1,
                    GivenName = "John", FamilyName = "Smith",
                    Rating = 7, StartDate = new DateTime(2000, 10, 1)},
                new Person() {Id = 2,
                    GivenName = "Mary", FamilyName = "Thomas",
                    Rating = 9, StartDate = new DateTime(1971, 7, 23)},
            };

            return people;
        }

        public Person GetPerson(int id)
        {
            var people = GetPeople();
            return people.FirstOrDefault(p => p.Id == id);
        }
    }
}

using System.Collections.Generic;
using Common;

namespace PersonReader.Service
{
    public interface IRepository
    {
        IReadOnlyCollection<Person> GetPeople();
        Person GetPerson(int id);
    }
}
using BeautyShop.Core;
using System.Collections.Generic;

namespace BeautyShop.Data
{
    public interface IPersonInMemory
    {
        Person AddPerson(Person person);
        Person UpdatePerson(Person person);
        Person GetPerson(int id);
        IEnumerable<Person> GetPeople(string searchName = null);
    }
}

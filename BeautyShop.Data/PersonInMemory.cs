using BeautyShop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautyShop.Data
{
    public class PersonInMemory : IPersonInMemory
    {
        public List<Person> People { get; set; }
        public PersonInMemory()
        {
            People = new List<Person>();
        }
        public Person AddPerson(Person person)
        {
            person.Id = People.Any() ? People.Max(x => x.Id) + 1 : 1;
            People.Add(person);
            return person;
        }

        public Person GetPerson(int id)
        {
            return People.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Person> GetPeople(string searchName = null)
        {
            return People.Where(x => string.IsNullOrEmpty(searchName) || x.Name.ToLower().Contains(searchName.ToLower()));
        }

        public Person UpdatePerson(Person person)
        {
            var tempPerson = People.SingleOrDefault(x => x.Id == person.Id);
            if (tempPerson!=null)
            {
                tempPerson.Name = person.Name;
                tempPerson.Membership = person.Membership;
                tempPerson.MembershipId = person.MembershipId;
            }
            return tempPerson;
        }
    }
}

using angularCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace angularCore.Factory
{
    public class PersonFactory
    {
        public PersonFactory()
        {
            
        }
        public Person create()
        {
            Person thePerson = new Person();
            thePerson.firstName = Faker.Name.First();
            thePerson.lastName = Faker.Name.Last();
            thePerson.dateOfBirth = Faker.DateOfBirth.Next();
            thePerson.height = Faker.RandomNumber.Next(50, 100);
            thePerson.weight = Faker.RandomNumber.Next(100, 250);

            return thePerson;

        }
        public List<Person> create(int numberToCreate)
        {
            List<Person> thePeople = new List<Person>();
            for(int i = 0; i < numberToCreate; i++)
            {
                thePeople.Add(this.create());
            }
            return thePeople;
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using test_2.Data;
using test_2.Models;

namespace test_2.Repositories
{
    public class PeopleRepositorie : IPeopleRepositorie
    {
        private readonly Context _context;
        public PeopleRepositorie(Context context)
        {
            _context = context;
        }
        public List<Person> AllPeoplePets()
        {
            var result = from person in _context.People
                         join pet in _context.Pets on person equals pet.Person
                         group person by person.Name into g
                         select new Person { Name = g.Key };
            var dataView = new List<Person>();

            foreach (var item in result)
            {
                dataView.Add(new Person() { Name = item.Name });
            }
            return dataView;
        }
        public List<Person> GetPeopleSons()
        {

            var result = from p in _context.People
                         where p.Sons > 0
                         join pet in _context.Pets on p equals pet.Person into wp
                         from subpet in wp.DefaultIfEmpty()
                         where subpet.Person == null
                         select new Person { Name = p.Name, Age = p.Age, Sons = p.Sons };
            var dataView = new List<Person>();

            foreach (var item in result)
            {
                dataView.Add(new Person() { Name = item.Name, Age = item.Age, Sons = item.Sons });

            }

            return dataView;
        }
        public List<Person> GetPets()
        {

            var result = from p in _context.People
                         join pet in _context.Pets
                         on p.Id equals pet.Person.Id into pt
                         from subpet in pt.DefaultIfEmpty()
                         group subpet by new {subpet.Id, subpet.Person.Name} into gp
                         select new Person { Name = gp.Key.Name, PetsId = gp.Count()};
            var dataView = new List<Person>();

            foreach (var item in result)
            {
                Console.WriteLine(item);

            }

            return dataView;
        }

    }
}

using NapaEduWebAppMVC.Context;
using NapaEduWebAppMVC.Models;

namespace NapaEduWebAppMVC.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly AppDbContext _context;
        public PeopleService(AppDbContext context)
        {
            _context = context;
        }

        public bool AddPerson(Person person)
        {
            _context.People.Add(person);
            _context.SaveChanges();
            return true;
        }

        public bool DeletePerson(int id)
        {
            var person = _context.People.Find(id);
            if (person != null)
            {
                _context.People.Remove(person);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public ICollection<Person> GetPeople()
        {
            var people = _context.People;
            return people.ToList();
        }

        public Person GetPerson(int id)
        {
            var person = _context.People.Find(id);
            if(person != null)
                return person;
            return new Person();
        }

        public bool UpdatePerson(int id, Person person)
        {
            var foundPerson = _context.People.Find(id);
            if (foundPerson != null)
            {
                if(!string.IsNullOrEmpty(foundPerson.Name))
                    foundPerson.Name = person.Name;
                if(person.Age > 0)
                    foundPerson.Age = person.Age;
                _context.People.Update(foundPerson);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

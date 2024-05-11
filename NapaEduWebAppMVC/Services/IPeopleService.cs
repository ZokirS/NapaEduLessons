using NapaEduWebAppMVC.Models;

 namespace NapaEduWebAppMVC.Services
{
    public interface IPeopleService
    {
        ICollection<Person> GetPeople();
        Person GetPerson(int id);
        bool AddPerson(Person person);
        bool UpdatePerson(int id, Person person);
        bool DeletePerson(int id);
    }
}

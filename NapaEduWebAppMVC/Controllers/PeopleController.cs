using Microsoft.AspNetCore.Mvc;
using NapaEduWebAppMVC.Services;
using NapaEduWebAppMVC.Models;

namespace NapaEduWebAppMVC.Controllers
{
    public class PeopleController: Controller
    {
        private readonly IPeopleService _service;

        public PeopleController(IPeopleService service) 
            => _service = service;

        [HttpGet]
        public IActionResult Index()
        {
            var people = _service.GetPeople();
            return View(people);
        }

        [HttpGet]
        public IActionResult Person(int id)
        {
            var person = _service.GetPerson(id);  
            return View(person);
        }

        public IActionResult EditPerson(int id)
        {
            var person = _service.GetPerson(id);
            return View(person);
        }
        [HttpPost]
        public IActionResult EditPerson(int id, Person person)
        {
            var editedPerson = _service.UpdatePerson(id, person);
            return RedirectToAction("Person", new { id = id });
        }

        public IActionResult AddPerson()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
            _service.AddPerson(person);
            return RedirectToAction("Index");
        }


        public IActionResult DeletePerson(int id)
        {
            var person = _service.GetPerson(id);
            return View(person);
        }
        [HttpPost]
        public IActionResult DeletePerson(Person person)
        {
            _service.DeletePerson(person.Id);
            return RedirectToAction("Index");
        }
    }
}

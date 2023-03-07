using System;
using Microsoft.AspNetCore.Mvc;
using soalYEk.DAl;
using soalYEk.Models;

namespace soalYEk.Controllers
{
	public class AccountController: Controller
	{
		PersonRepository personRepository = new PersonRepository(); 
		public IActionResult Register()
		{
			return View();
		}
		[HttpPost]
        public IActionResult Register(Person person)
        {
			personRepository.register(person);
            return RedirectToAction("List");
            
        }
        public IActionResult List()
        {
            List<Person> people=personRepository.ListPerson();
            return View(people);
        }
    }
}


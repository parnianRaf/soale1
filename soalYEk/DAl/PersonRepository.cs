using System;
using soalYEk.Models;

namespace soalYEk.DAl
{
	public class PersonRepository
	{
		public Person findPerson(int id)
		{
			Person? person = DataBase.DataBase.People.FirstOrDefault(p => p.Id == id);
			return person;
		}
		public void register(Person person)
		{
			DataBase.DataBase.People.Add(person);
		}
		public List<Person> ListPerson()
		{
			List<Person> people_ = DataBase.DataBase.People;
			return people_;
		}
	
	}
}


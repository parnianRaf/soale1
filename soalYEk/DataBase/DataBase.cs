using System;
using soalYEk.Models;

namespace soalYEk.DataBase
{
	public static class DataBase
	{
		public static List<Person> People { get; set; } = new List<Person>()
		{
			new Person()
			{
				Email = "par@",
				Phone = "09883"

			},
			new Person()
			{
				Email = "ourehf",
				Phone = "3u74t"
			},
			new Person()
			{
				Email="rggtre",
				Phone="rtgq"

			}
		};

	}
}


using System;
using System.ComponentModel.DataAnnotations;

namespace soalYEk.Models
{
	public class Person
	{
		public int Id { get; set; }
		[Required(ErrorMessage ="it shouldn't be empty")]
		[Display(Name ="ایمیل")]
		public string Email { get; set; }
		[StringLength(11,ErrorMessage ="it should'nt exceed 11 characters.")]
		[Display(Name ="شماره تماس")]
        public string Phone { get; set; }

    }
}


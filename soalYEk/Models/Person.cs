using System;
using System.ComponentModel.DataAnnotations;

namespace soalYEk.Models
{
	public class Person
	{
		public int Id { get; set; }



		[Required(ErrorMessage ="{0} shouldn't be empty")]
		[Display(Name ="ایمیل")]
		public string Email { get; set; }



        [Required(ErrorMessage = "{0} shouldn't be empty")]
        //[StringLength(11,ErrorMessage ="")]
        [Display(Name ="شماره تماس")]
		[Range(9,11,ErrorMessage = "PhoneNumber should include 11 characters.")]
        public string? Phone { get; set; }

    }
}


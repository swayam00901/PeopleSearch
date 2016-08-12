using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleDB.Models
{
    public class Student : Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Age")]
        public int Age
        {

            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - BirthDate.Year;

                if (BirthDate > today.AddYears(-age))
                    age--;
                return age;
            }
        }
    }
}
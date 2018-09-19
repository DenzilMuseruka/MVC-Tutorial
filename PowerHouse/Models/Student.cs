using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PowerHouse.Models
{
    public enum Gender
    {
        Male = 1,
        Female,
        Unspecified
    }
    public class Student
    {
        [Display(Name = "Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Picture")]
        public string ProfilePic { get; set; }

        [Display(Name = "Surname")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Gender")]
        public Gender Gender { get; set; }
        public int StudentId { get; set; }
        [NotMapped]
        public List<Subject> Subjects { get; set; }
        public string ClassCode { get; set; }
    }
}

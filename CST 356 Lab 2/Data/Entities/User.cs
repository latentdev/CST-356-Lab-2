using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CST_356_Lab_2.Data.Entities
{
    public class User
    {
        [Required()]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required()]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required()]
        public string Email { get; set; }
        [Required()]
        [Display(Name = "Years In School")]
        public int YearsInSchool { get; set; }

        public bool IsValid()
        {
            if (FirstName != null && LastName != null && Email.Contains("@"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
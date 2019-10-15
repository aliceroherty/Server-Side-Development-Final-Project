using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Real_Estate_Application.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required]
        [LegalAge]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(75)]
        public string Email { get; set; }

        [Required]
        [StringLength(14)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(30)]
        public string StreetAddress { get; set; }

        [Required]
        [StringLength(30)]
        public string City { get; set; }

        public int AgentID { get; set; }
    }

    internal class LegalAgeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dob = (DateTime)value;

            int age = DateTime.Now.Year - dob.Year;

            if (DateTime.Now.DayOfYear < dob.DayOfYear)
            {
                age--;
            }

            if (age < 19)
            {
                return new ValidationResult("The Customer must be 19 or older.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
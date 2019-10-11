using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Real_Estate_Application.Models
{
    public class Agent
    {
        public int AgentID { get; set; }

        [Required]
        [StringLength(11)]
        public string SIN { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(30)]
        public string StreetAddress { get; set; }

        [Required]
        [StringLength(30)]
        public string City { get; set; }

        [Required]
        [StringLength(30)]
        public string Province { get; set; }

        [Required]
        [StringLength(6)]
        public string PostalCode { get; set; }

        [StringLength(14)]
        public string HomePhone { get; set; }

        [StringLength(14)]
        public string CellPhone { get; set; }

        [StringLength(14)]
        public string OfficePhone { get; set; }

        [Required]
        [StringLength(75)]
        public string OfficeEmail { get; set; }

        [Required]
        [StringLength(25)]
        public string LoggedInUsername { get; set; }
    }
}
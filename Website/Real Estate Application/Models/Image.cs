using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Real_Estate_Application.Models
{
    public class Image
    {
        public int ImageID { get; set; }

        public string FilePath { get; set; }

        public string FileName { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        [StringLength(30)]
        public string AlternativeText { get; set; }

        public DateTime UploadDateTime { get; set; }

        public int StaffMemberID { get; set; }

        public bool IsApproved { get; set; } = false;
    }
}
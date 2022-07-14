using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace umbTraining.Models
{
    public class ContactModel
    {
        [Required]
        [MaxLength(100)]
        public string ContactName { get; set; }
        [Required]
        public string ContactEmail { get; set; }
        public string Message { get; set; }

    }
}
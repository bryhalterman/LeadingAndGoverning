using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeadingAndGoverning.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "A subject is required.")]
        [MaxLength(100, ErrorMessage = "Subject can be no longer than 100 characters long.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "A message is required.")]
        public string Body { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
    }
}
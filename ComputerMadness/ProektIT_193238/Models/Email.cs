using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProektIT_193238.Models
{
    public class Email
    {
        public string Subject { get; set; }
        [Required(ErrorMessage = "A message is required.")]
        [Display(Name = "Message")]
        public string Body { get; set; }
        [Required(ErrorMessage = "Please enter your email.")]
        [Display(Name = "Email")]
        public string UserEmail { get; set; }
        public string Password { get; set; }
    }
}
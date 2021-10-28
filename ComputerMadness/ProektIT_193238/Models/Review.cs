using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProektIT_193238.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Required]
        public string Category { get; set; }
        public List<string> Categories { get; set; }
        [Required]
        public string Comment { get; set; }
        [Required]
        public int Rating { get; set; }
        [Display(Name = "Date Added")]
        public string CurrentDate { get; set; }
    }
}
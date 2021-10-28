using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProektIT_193238.Models
{
    public class Laptop
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Image")]
        public string ImgURL { get; set; }
        [Required]
        [Display(Name = "Model")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string HDD { get; set; }
        public string SSD { get; set; }
        public string RAM { get; set; }
        public string OS { get; set; }
        public string Display { get; set; }
        public string Battery { get; set; }
        public string Weight { get; set; }
    }
}
using System;
using System.Web;
//using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ATMWebApplication.Models
{
    public class Customer
    {

        public int ID { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string AccountNum { get; set; }

        [Required]
        [Compare("Pin", ErrorMessage = "Passwords must match")]
        public string Pin { get; set; }
        [Required]
        public int Balance { get; set; }
    }
}

using System;
using System.Web;
//using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ATMWebApplication.Models
{
    public class Customer
    {

        public int ID { get; set; }
        public string FullName { get; set; }
        [Required]
        public string AccountNum { get; set; }

        [Required]
        [Compare("Pin", ErrorMessage = "Passwords must match")]
        public string Pin { get; set; }
        public int Balance { get; set; }
    }
}

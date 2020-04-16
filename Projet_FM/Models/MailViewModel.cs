using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projet_FM.Models
{
    public class MailViewModel
    {
        public int Id { get; set; }


        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }


        [Required]
        [Display(Name = "Subject")]
        public string Subject { get; set; }


        [Required]
        [Display(Name = "Message")]
        public string Message { get; set; }

    }
}
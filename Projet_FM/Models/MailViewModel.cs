using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projet_FM.Models
{
    public class MailViewModel
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email_M { get; set; }


        [Required]
        [Display(Name = "Name")]
        public string Name_M { get; set; }


        [Required]
        [Display(Name = "Subject")]
        public string Subject_M { get; set; }


        [Required]
        [Display(Name = "Message")]
        public string Message_M { get; set; }

    }
}
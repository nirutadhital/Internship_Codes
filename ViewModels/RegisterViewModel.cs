using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyNotes.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name ="First Name")]
        public string? FirstName {get;set;}

        [Required]
        [Display(Name ="Last Name")]
        public string? LastName {get; set;}

        [Required]
        [Display(Name ="Email Address")]
        [EmailAddress]
        public string? Email {get; set;}

        [Required]
        public string? Password {get; set;}
        
        [Required]
        [Display(Name ="Confirmed Password")]
        [Compare("Password")]
        public string? ConfirmPassword {get; set;}


        
    }
}
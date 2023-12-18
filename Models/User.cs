using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MyNotes.Models
{
    public class User: IdentityUser
    {
        public string? FirstName {get; set;}
        public string? LastName {get; set;}

        public List<Note>? Note {get; set;}
        
    }
}
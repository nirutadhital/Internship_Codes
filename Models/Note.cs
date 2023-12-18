using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNotes.Models
{
    public class Note
    {
        public int Id {get; set;}
        public string? Title {get; set;}

        public string? Description {get; set;}

        public string? Color {get; set;}

        public DateTime CreatedDate {get; set;}=DateTime.Now;

        public string? UserId {get; set;}//this user id is foreign key from User table

        public User? User {get; set;}
    }
}
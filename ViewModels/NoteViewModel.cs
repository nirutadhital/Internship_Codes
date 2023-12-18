using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyNotes.ViewModels
{
    public class NoteViewModel
    {
        public int Id {get; set;}
        [Required]
        public string? Title {get; set;}
        public string? Description {get; set;}
        [Required]
        public string? Color {get; set;}
        public DateTime CreatedDate {get; set;}=DateTime.UtcNow;
        public string? UserId {get; set;}
    }
}
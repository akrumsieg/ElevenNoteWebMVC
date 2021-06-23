using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Titles must have 2-40 characters.")]
        [MaxLength(40, ErrorMessage = "Titles must have 2-40 characters.")]
        public string Title { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Notes must have 1-1000 characters.")]
        [MaxLength(1000, ErrorMessage = "Notes must have 1-1000 characters.")]
        public string Content { get; set; }
    }
}

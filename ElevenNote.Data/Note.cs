using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Titles must have 2-40 characters.")]
        [MaxLength(40, ErrorMessage = "Titles must have 2-40 characters.")]
        public string Title { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Notes must have 1-1000 characters.")]
        [MaxLength(1000, ErrorMessage = "Notes must have 1-1000 characters.")]
        public string Content { get; set; }

        [Required]
        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}

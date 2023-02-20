using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_chanse99.Models
{
    public class MovieResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required(ErrorMessage ="Please enter a movie title.")]
        public string MovieTitle { get; set; }
        [Required(ErrorMessage = "Please enter the year the movie was released.")]
        public ushort Year { get; set; }
        [Required(ErrorMessage = "Please enter the name of the Director of the movie.")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Please select the accurate rating for the movie.")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }

        // Build Foreign Key Relationship
        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}

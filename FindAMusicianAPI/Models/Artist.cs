using System;
using System.ComponentModel.DataAnnotations;

namespace FindAMusicianAPI.Models{
    public class Artist{
        [Key]
        public int Id { get; set; }
        [Required]
        public string ArtistName { get; set; }
        [Required]
        public string Contact { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
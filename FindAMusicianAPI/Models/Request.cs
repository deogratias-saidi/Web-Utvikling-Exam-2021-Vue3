using System;
using System.ComponentModel.DataAnnotations;

namespace FindAMusicianAPI.Models{
    public class Request{
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]

        public int PhoneNumber { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int PostNumber { get; set; }
        [Required]
        public string PostalArea {get; set;}
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public decimal Budget { get; set; }
        [Required]
        public string RequestDetails { get; set; }
    }
}
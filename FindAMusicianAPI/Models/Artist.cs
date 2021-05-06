using System;

namespace FindAMusicianAPI.Models{
    public class Artist{
        public int Id { get; set; }
        public string ArtistName { get; set; }
        public string Contact { get; set; }
        public int Price { get; set; }
        public string Genre { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
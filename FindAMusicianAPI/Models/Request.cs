using System;

namespace FindAMusicianAPI.Models{
    public class Request{
        public int Id { get; set; }
        public string UserName { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public int PostNumber { get; set; }
        public string PostalArea {get; set;}
        public DateTime DateCreated { get; set; }
        public int Budget { get; set; }
        public string RequestDetails { get; set; }
    }
}
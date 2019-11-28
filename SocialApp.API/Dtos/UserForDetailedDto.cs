using System;
using System.Collections.Generic;
using SocialApp.API.Models;

namespace SocialApp.API.Dtos
{
    public class UserForDetailedDto
    {
        public int id { get; set; }
        public string username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string About { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotosForDetailedDto> Photos { get; set; }
    }
}
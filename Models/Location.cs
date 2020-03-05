using System.Collections.Generic;
using LightsaberCentral.Models;

namespace LightsaberCentral.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string ManagerName { get; set; }
        public int PhoneNumber { get; set; }
        public List<SaberLocations> SaberLocations { get; set; } = new List<SaberLocations>();
    }
}
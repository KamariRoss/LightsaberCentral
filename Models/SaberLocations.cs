using LightsaberCentral.Models;

namespace LightsaberCentral.Models
{
    public class SaberLocations
    {
        public int Id { get; set; }
        public int SaberId { get; set; }
        public Saber Saber { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
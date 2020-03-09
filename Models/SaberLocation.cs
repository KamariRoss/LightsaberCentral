namespace LightsaberCentral.Models
{
    public class SaberLocation
    {
        public int Id { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }

        public int SaberId { get; set; }
        public Saber Saber { get; set; }
    }
}
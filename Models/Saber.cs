using System;
using System.Collections.Generic;
using LightsaberCentral.Models;

namespace LightsaberCentral.Models
{
    public class Saber
    {
        // Id
        public int Id { get; set; }
        //SKU
        public string SKU { get; set; }
        //Name
        public string Name { get; set; }
        //Short description
        public string Description { get; set; }
        //NumberInStock
        public int NumberInStock { get; set; }
        // Price
        public double Price { get; set; }
        //DateOrdered
        public DateTime DateOrdered { get; set; }
        public List<SaberLocation> SaberLocations { get; set; } = new List<SaberLocation>();

    }
}
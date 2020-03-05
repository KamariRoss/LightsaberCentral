using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using LightsaberCentral.Models;
using Microsoft.AspNetCore.Mvc;

namespace LightsaberCentral.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        public DatabaseContext db { get; set; } = new DatabaseContext();

        [HttpPost]
        public Location CreateStore(Location item)
        {
            // Add a light saber
            db.Locations.Add(item);
            db.SaveChanges();
            return item;
        }
        [HttpGet]
        public List<Location> ListAllLocations()
        {
            var findLocation = db.Locations.OrderBy(p => p.Id);
            return findLocation.ToList();
        }
    }
}
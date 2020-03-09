using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using LightsaberCentral.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        [HttpDelete("{Id}")]
        public Location DeleteYourSaber(int id)
        {
            // PUT /api/sabers/{id}/play, This should find the saber by id,
            var locate = db.Locations.FirstOrDefault(p => p.Id == id);
            db.Locations.Remove(locate);
            db.SaveChanges();
            return locate;
        }
        [HttpPut("{id}/{Locate}/update")]
        public Location UpdateLocation(int id, Location newData, int Locate)

        {
            var itemlocation = new SaberLocation()
            {
                LocationId = Locate
            };
            newData.SaberLocations.Add(itemlocation);
            newData.Id = id;
            db.Entry(newData).State = EntityState.Modified;
            db.SaveChanges();
            return newData;
        }
    }
}
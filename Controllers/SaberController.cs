using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LightsaberCentral.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LightsaberCentral.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaberController : ControllerBase
    {
        public DatabaseContext db { get; set; } = new DatabaseContext();

        [HttpPost("{Id}")]
        public Saber CreateLightsaber(Saber item, int Id)
        {
            // Add a light saber
            // the id in saberlocations is the same as the saber id
            // assign the location(s) to the saber
            var itemlocation = new SaberLocation()
            {
                LocationId = Id
            };
            item.SaberLocations.Add(itemlocation);
            db.Sabers.Add(item);
            db.SaveChanges();
            item.SaberLocations = null;
            return item;
        }
        [HttpDelete("{Id}")]
        public Saber DeleteYourSaber(int id)
        {
            // PUT /api/sabers/{id}/play, This should find the saber by id,
            var saber = db.Sabers.FirstOrDefault(p => p.Id == id);
            db.Sabers.Remove(saber);
            db.SaveChanges();
            return saber;
        }
        [HttpGet("{Id}/{Location}")]
        public ActionResult GetSaber(int id, int Location)
        {
            //query for all sabers
            // sort them by Id 
            // var viewAllSabers = SaberLocation()

            var saberlocations = db.SaberLocations
                    .Include(i => i.Saber)
                    .Where(w => w.LocationId == Location)
                    .Where(r => r.SaberId == id)
                    .Select(s => s.Saber).ToList();
            return Ok(saberlocations);
            // return the list 
        }
        [HttpGet("All/{Location}")]
        public ActionResult GetAllInvenetory(int Location)
        {
            // find the location
            // join to middle table
            // pull out all sabers that have the location id equal to location
            // var sabers = db.Sabers.OrderBy(p => p.Name);

            // var sabers = db.Sabers.Include(b => b.SaberLocations.Where(c => c.LocationId == Location));
            // var showSabers = sabers.OrderByDescending(s => s.Name);
            // filter
            // this  joins the table
            // return the sorted items  
            // return showSabers.ToList();

            var saberlocations = db.SaberLocations
                    .Include(i => i.Saber)
                    .Where(w => w.LocationId == Location)
                    .Select(s => s.Saber).ToList();
            return Ok(saberlocations);
        }
        [HttpGet("Out")]
        // Create a GET endpoint to get all items that are out of stock
        public List<Saber> OutOfStock()
        {
            // find all sabers where numberInStock == 0
            var sabers = db.Sabers.Where(p => p.NumberInStock == 0);
            // return a list of sabers with only 0
            return sabers.ToList();
        }
        [HttpGet("Out/{Id}")]
        // Create a GET endpoint to get all items that are out of stock
        public ActionResult OutOfStockLocation(int Id)
        {

            // find all sabers where numberInStock == 0
            var saberlocations = db.SaberLocations
                                .Include(i => i.Saber)
                                .Where(w => w.LocationId == Id)
                                .Select(s => s.Saber).ToList();
            return Ok(saberlocations);
            // return a list of sabers with only 0
        }
        [HttpGet("Sku/{sku}")]
        public ActionResult FindSKU(string sku)
        {
            //var sabers = db.Sabers.Include(b => b.SaberLocations.Where(s => s.LocationId == Location));

            var sabers = db.Sabers.Where(p => p.SKU == sku);
            if (sabers == null)
            {
                return NotFound();
            }
            return Ok(sabers);

        }
        [HttpPut("Update/{id}/{Locate}")]
        // Create a PUT endpoint that allows a client to update an item
        public Saber UpdateSabers(int id, Saber newData, int Locate)

        {
            var itemlocation = new SaberLocation()
            {
                LocationId = Locate
            };
            newData.Id = id;
            newData.SaberLocations.Add(itemlocation);
            db.Entry(newData).State = EntityState.Modified;
            db.SaveChanges();
            newData.SaberLocations = null;
            return newData;
        }


    }
}




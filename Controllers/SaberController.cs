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

        [HttpPost]
        public Saber CreateLightsaber(Saber item)
        {
            // Add a light saber
            db.Sabers.Add(item);
            db.SaveChanges();
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
        [HttpGet("{Id}")]
        public Saber GetSaber(int id)
        {
            //query for all sabers
            // sort them by Id 
            var sabers = db.Sabers.FirstOrDefault(p => p.Id == id);
            // return the list 
            return sabers;
        }
        [HttpGet("All")]
        public List<Saber> GetAllInvenetory()
        {
            // query for all the sabers
            // sort them by name
            var sabers = db.Sabers.OrderBy(p => p.Name);
            // return the sorted items  
            return sabers.ToList();
        }
        [HttpGet("OUT")]
        // Create a GET endpoint to get all items that are out of stock
        public List<Saber> OutOfStock()
        {
            // find all sabers where numberInStock == 0
            var sabers = db.Sabers.Where(p => p.NumberInStock == 0);
            // return a list of sabers with only 0
            return sabers.ToList();
        }
        [HttpGet("Sku/{sku}")]
        public ActionResult FindSKU(string sku)
        {
            var sabers = db.Sabers.Where(p => p.SKU == sku);
            if (sabers == null)
            {
                return NotFound();
            }
            return Ok(sabers);

        }
        [HttpPut("{id}/update")]
        // Create a PUT endpoint that allows a client to update an item
        public Saber UpdateSabers(int id, Saber newData)

        {
            newData.Id = id;
            db.Entry(newData).State = EntityState.Modified;
            db.SaveChanges();
            return newData;
        }


    }
}




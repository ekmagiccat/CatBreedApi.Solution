using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CatBreed.Models;
using System.Linq;

namespace CatBreed.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatBreedController : ControllerBase
    {
        private readonly CatBreedContext _db;

        public CatBreedController(CatBreedContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<List<Cat>> Get(string breedName, string fur, string temperament, int avgKittenPrice, int usPopularity)
        {
            IQueryable<Cat> query = _db.Cats.AsQueryable();

            if (breedName != null)
            {
                query = query.Where(entry => entry.BreedName == breedName);
            }
            if (fur != null)
            {
                query = query.Where(entry => entry.Fur == fur);
            }
            if (temperament != null)
            {
                query = query.Where(entry => entry.Temperament == temperament);
            }
            if (avgKittenPrice > 0)
            {
                query = query.Where(entry => entry.AvgKittenPrice == avgKittenPrice);
            }
            if (usPopularity > 0)
            {
                query = query.Where(entry => entry.UsPopularity == usPopularity);
            }

            return await query.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cat>> GetCat(int id)
        {
            Cat cat = await _db.Cats.FindAsync(id);

            if (cat == null)
            {
                return NotFound();
            }
            return cat;
        }

        [HttpPost]
        public async Task<ActionResult<Cat>> Post(Cat cat)
        {
            _db.Cats.Add(cat);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCat), new { id = cat.CatId }, cat);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Cat cat)
        {
            if (id != cat.CatId)
            {
                return BadRequest();
            }
            _db.Cats.Update(cat);
            try
            {
                await _db.SaveChangesAsync();
            }
            catch
            {
                if (!CatExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        private bool CatExists(int id)
        {
            return _db.Cats.Any(c => c.CatId == id);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCat(int id)
        {
            Cat cat = await _db.Cats.FindAsync(id);
            if (cat == null)
            {
                return NotFound();
            }

            _db.Cats.Remove(cat);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}

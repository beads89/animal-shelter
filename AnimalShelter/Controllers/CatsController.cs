using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Versioning;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  //[ApiKey] - Not required, open API
  [ApiController]
  [ApiVersion("1.0")]
  //[Route("api/[controller]")]
  [Route("api/cats")]
  public class CatsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    
    public CatsController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET: api/cats
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cat>>> Get(string name, string gender, string breed, string color)
    {
      var query = _db.Cats.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.CatName.Contains(name));
      }

      if (gender != null)
      {
        query = query.Where(entry => entry.CatGender == gender);
      }

      if (breed != null)
      {
        query = query.Where(entry => entry.CatBreed.Contains(breed));
      }

      if (color !=null)
      {
        query = query.Where(entry => entry.CatColor.Contains(color));
      }

      return await query.ToListAsync();
    }

    // GET: api/cats/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Cat>> GetCat(int id)
    {
        var cat = await _db.Cats.FindAsync(id);

        if (cat == null)
        {
            return NotFound();
        }

        return cat;
    }

    // PUT: api/cats/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Cat cat)
    {
      if (id != cat.CatId)
      {
        return BadRequest();
      }

      _db.Entry(cat).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
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

    // POST: api/cats
    [HttpPost]
    public async Task<ActionResult<Cat>> Post(Cat cat)
    {
      _db.Cats.Add(cat);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetCat), new { id = cat.CatId }, cat);
    }

    // DELETE: api/cats/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCat(int id)
    {
      var cat = await _db.Cats.FindAsync(id);
      if (cat == null)
      {
        return NotFound();
      }

      _db.Cats.Remove(cat);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool CatExists(int id)
    {
      return _db.Cats.Any(cat => cat.CatId == id);
    }
  }
}
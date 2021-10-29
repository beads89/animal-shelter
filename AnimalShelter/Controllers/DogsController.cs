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
  [Route("api/dogs")]
  public class DogsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    
    public DogsController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET: api/dogs
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Dog>>> Get(string name, string gender, string breed, string color)
    {
      var query = _db.Dogs.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.DogName.Contains(name));
      }

      if (gender != null)
      {
        query = query.Where(entry => entry.DogGender == gender);
      }

      if (breed != null)
      {
        query = query.Where(entry => entry.DogBreed.Contains(breed));
      }

      if (color !=null)
      {
        query = query.Where(entry => entry.DogColor.Contains(color));
      }

      return await query.ToListAsync();
    }

    // GET: api/dogs/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Dog>> GetDog(int id)
    {
        var dog = await _db.Dogs.FindAsync(id);

        if (dog == null)
        {
            return NotFound();
        }

        return dog;
    }

    // PUT: api/dogs/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Dog dog)
    {
      if (id != dog.DogId)
      {
        return BadRequest();
      }

      _db.Entry(dog).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!DogExists(id))
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

    // POST: api/dogs
    [HttpPost]
    public async Task<ActionResult<Dog>> Post(Dog dog)
    {
      _db.Dogs.Add(dog);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetDog), new { id = dog.DogId }, dog);
    }

    // DELETE: api/dogs/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDog(int id)
    {
      var dog = await _db.Dogs.FindAsync(id);
      if (dog == null)
      {
        return NotFound();
      }

      _db.Dogs.Remove(dog);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool DogExists(int id)
    {
      return _db.Dogs.Any(dog => dog.DogId == id);
    }
  }
}
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parks.Models;

namespace Parks.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private ParksContext _db;

    public ParksController(ParksContext db)
    {
      _db = db;
    }

    // GET api/parks
    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get(string name, string info, string alerts)
    {
        var query = _db.Parks.AsQueryable();

        if (name != null)
        {
        query = query.Where(entry => entry.Name == name);
        }

        if (info != null)
        {
        query = query.Where(entry => entry.Info == info);
        }

        if (alerts != null)
        {
        query = query.Where(entry => entry.Alerts == alerts);
        }

        return query.ToList();
    }

    // POST api/parks
    [HttpPost]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }

    // GET api/parks/5
    [HttpGet("{id}")]
    public ActionResult<Park> Get(int id)
    {
        return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
    }

    // PUT api/parks/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Park park)
    {
        park.ParkId = id;
        _db.Entry(park).State = EntityState.Modified;
        _db.SaveChanges();
    }

    // DELETE api/parks/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      _db.Parks.Remove(parkToDelete);
      _db.SaveChanges();
    }

  }
}
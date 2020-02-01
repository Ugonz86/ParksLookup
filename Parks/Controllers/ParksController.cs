using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parks.Models;
using System;

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

    [HttpPost]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<Park> Get(int id)
    {
        return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
    }

//     [HttpGet("{id}")]
//     public ActionResult<Park> GetRandom(int id)
//     {
//       var rand = new Random();

// //this is a test
// var bytes = new byte[5];
// rand.NextBytes(bytes);
// Console.WriteLine("Five random byte values:");
// foreach (byte byteValue in bytes)
//     Console.Write("{0, 5}", byteValue);
// Console.WriteLine(); 
// return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
//       // Random randomId = new Random(id);
//       // int parkIds = ;

//       // int mIndex = randomId.Next(parkIds.Length);

//       // return randomId;

//       // Console.WriteLine(randomId.Next(0,6));
//       // return _db.Parks.FirstOrDefault(entry => entry.ParkId == int.Parse(randomId));
//     }


    // [HttpGet("{id}")] //Random
    // private static readonly Random random = new Random(); 
    // private static readonly object syncLock = new object(); 
    // public static int RandomNumber(int id, int max)
    // {
    //     lock(syncLock) { // synchronize
    //         return random.Next(min, max);
    //     }
    // }


    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Park park)
    {
        park.ParkId = id;
        _db.Entry(park).State = EntityState.Modified;
        _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      _db.Parks.Remove(parkToDelete);
      _db.SaveChanges();
    }

  }
}
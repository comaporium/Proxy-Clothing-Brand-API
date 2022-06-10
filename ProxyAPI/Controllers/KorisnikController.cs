using Microsoft.AspNetCore.Mvc;
using ProxyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProxyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {
        OnlineShopContext db = new OnlineShopContext();

        [HttpPost]
        public IActionResult unesiKorisnika([FromBody] Korisnik podaci)
        {
            db.Add(podaci); 
            db.SaveChanges();
            return Ok(podaci);
        }

        [HttpGet]
        public IActionResult sviKorisnici()
        {
            List<Korisnik> osobe = db.Korisniks.OrderByDescending(x => x.Idkorisnika).ToList();
            return Ok(osobe);
        }
    }
}

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
    public class ArtikliController : ControllerBase
    {
        OnlineShopContext db = new OnlineShopContext();

        [HttpGet]
        public IActionResult sviArtikli()
        {
            List<Artikli> rezultatArtikala = db.Artiklis.OrderByDescending(x=>x.Idartikla).ToList();
            return Ok(rezultatArtikala);
        }

        [HttpGet]
        public IActionResult ArtikalPoIDu(int id)
        {
            List<Artikli> artikal = db.Artiklis.Where(x => x.Idartikla == id).ToList();
            return Ok(artikal);
        }
    }
}

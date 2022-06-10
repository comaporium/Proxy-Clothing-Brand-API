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
    public class SveOartiklimaController : ControllerBase
    {
        OnlineShopContext db = new OnlineShopContext();

        [HttpGet]
        public IActionResult sveOArtiklimaAll()
        {
            List<VwSveOartiklima> sviArtikli = db.VwSveOartiklimas.OrderByDescending(x => x.Idartikla).ToList();
            return Ok(sviArtikli);
        }

        [HttpGet]
        public IActionResult sveZaArtikalPoIDu(int id)
        {
            List<VwSveOartiklima> artikal = db.VwSveOartiklimas.Where(x => x.Idartikla == id).ToList();
            return Ok(artikal);
        }
        [HttpGet]
        public IActionResult sveZaArtikalPoParentu(string par)
        {
            List<VwSveOartiklima> artikli = db.VwSveOartiklimas.Where(x => x.Parent == par).ToList();
            return Ok(artikli);
        }
    }
}

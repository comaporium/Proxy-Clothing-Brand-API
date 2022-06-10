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
    public class SlikeArtikalaController : ControllerBase
    {
        OnlineShopContext db = new OnlineShopContext();

        [HttpGet]
        public IActionResult sveSlike()
        {
            List<VwSlikeArtikala> rezultatSlika = db.VwSlikeArtikalas.OrderByDescending(x => x.Idartikla).ToList();
            return Ok(rezultatSlika);
        }


        [HttpGet]
        public IActionResult slikaPoIDu(int id)
        {   
            List<VwSlikeArtikala> slika = db.VwSlikeArtikalas.Where(x => x.Idartikla == id).ToList();
            return Ok(slika);
        }
    }
}

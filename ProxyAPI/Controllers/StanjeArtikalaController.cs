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
    public class StanjeArtikalaController : ControllerBase
    {
        OnlineShopContext db = new OnlineShopContext();

        [HttpGet]
        public IActionResult StanjePoIDu(int id)
        {
            List<VwStanjeArtikala> stanje = db.VwStanjeArtikalas.Where(x => x.Idartikla == id).ToList();
            return Ok(stanje);
        }

        
    }
}

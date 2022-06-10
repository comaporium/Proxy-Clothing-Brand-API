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
    public class KorpaController : ControllerBase
    {
        OnlineShopContext db = new OnlineShopContext();

        [HttpPost]
        public IActionResult unesiKorpa([FromBody] Korpa podaci)
        {
            db.Add(podaci);
            db.SaveChanges();
            return Ok(podaci);
        }
    }
}

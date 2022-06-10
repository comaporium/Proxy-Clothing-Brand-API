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
    public class VelicineController : ControllerBase
    {
        OnlineShopContext db = new OnlineShopContext();

        [HttpGet]

        public IActionResult getVelicine()
        {
            List<Velicine> velicine = db.Velicines.OrderByDescending(x => x.Idvelicine).ToList();
            return Ok(velicine);
        }
    }
}

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
    public class ZadnjiPetAccesoriesController : ControllerBase
    {
        OnlineShopContext baza = new OnlineShopContext();

        [HttpGet]
        public IActionResult getZadnjihPetAccesories()
        {
            List<VwZadnjiPetAccesory> rezultat = baza.VwZadnjiPetAccesories.OrderByDescending(x => x.Idartikla).ToList();
            return Ok(rezultat);
        }
    }
}

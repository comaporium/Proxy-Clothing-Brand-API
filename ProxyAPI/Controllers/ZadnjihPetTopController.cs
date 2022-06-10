﻿using Microsoft.AspNetCore.Mvc;
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
    public class ZadnjihPetTopController : ControllerBase
    {
        OnlineShopContext baza = new OnlineShopContext();

        [HttpGet]
        public IActionResult getZadnjihPetTop()
        {
            List<VwZadnjiPetTop> rezultat = baza.VwZadnjiPetTops.OrderByDescending(x => x.Idartikla).ToList();
            return Ok(rezultat);
        }
    }
}

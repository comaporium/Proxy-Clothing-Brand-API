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
    public class StanjeController : ControllerBase
    {
        OnlineShopContext db = new OnlineShopContext();

        [HttpPut]
        public IActionResult umanjenjeStanja(int idA, int idV)
        {
            Stanje st = db.Stanjes.Where(x => x.Idartikla == idA && x.Idvelicine == idV).FirstOrDefault();
            st.Stanje1 = st.Stanje1 - 1;
            db.SaveChanges();
            return Ok(st);
        }

        [HttpPut]
        public IActionResult povecanjeStanja(int idA, int idV)
        {
            Stanje st = db.Stanjes.Where(x => x.Idartikla == idA && x.Idvelicine == idV).FirstOrDefault();
            st.Stanje1 = st.Stanje1 + 1;
            db.SaveChanges();
            return Ok(st);
        }
    }
}

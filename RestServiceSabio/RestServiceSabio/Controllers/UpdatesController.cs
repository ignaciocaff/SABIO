using Microsoft.AspNetCore.Mvc;
using RestServiceSabio.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestServiceSabio.Controllers
{
    [Route("api/[controller]")]
    public class UpdatesController : Controller
    {
        // GET api/session/login/juan
        [HttpGet("pendientes")]
        public IActionResult GetUpdates()
        {
            UpdateManager updateManager = new UpdateManager();
            return Ok(updateManager.existenUpdates());
        }

        // GET api/session/login/juan
        [HttpGet("articulos")]
        public IActionResult GetArticulos()
        {
            UpdateManager updateManager = new UpdateManager();
            return Ok(updateManager.obtenerArticulos());
        }
    }
}

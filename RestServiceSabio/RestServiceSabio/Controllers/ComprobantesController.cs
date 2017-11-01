using System;
using Microsoft.AspNetCore.Mvc;
using RestServiceSabio.Model;
using RestServiceSabio.Managers;

namespace RestServiceSabio.Controllers
{
    [Route("api/[controller]")]
    public class ComprobantesController : Controller
    {
        private SessionManager sessionManager = new SessionManager();
        private ComprobantesManager comprobantesManager = new ComprobantesManager();
        private Usuario user = new Usuario();
        // GET api/comprobantes/get/juan
        [HttpGet("get/{userId}")]
        public IActionResult GetComprobantes(String userId)
        {
            user.loginUsuario = userId;
            user = sessionManager.obtenerUsuarioCompleto(user);
            return Ok(comprobantesManager.obtenerComprobante(user));
        }

        [HttpPost("ingresar/{userId}")]
        public IActionResult Post(String userId, [FromBody]Comprobante comprobante)
        {
            user.loginUsuario = userId;
            user = sessionManager.obtenerUsuarioCompleto(user);
            return Ok(comprobantesManager.guardarStock(user, comprobante));
        }
    }
}
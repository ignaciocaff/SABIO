using Microsoft.AspNetCore.Mvc;
using RestServiceSabio.Managers;
using RestServiceSabio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestServiceSabio.Controllers
{
    [Route("api/[controller]")]
    public class EntradaSalidaController : Controller
    {
        private SessionManager sessionManager = new SessionManager();
        private ComprobantesManager comprobantesManager = new ComprobantesManager();
        private Usuario user = new Usuario();

        [HttpPost("ingresar/{userId}")]
        public IActionResult Post(String userId, [FromBody]Comprobante comprobante)
        {
            user.loginUsuario = userId;
            user = sessionManager.obtenerUsuarioCompleto(user);
            return Ok(comprobantesManager.guardarComprobanteES(user, comprobante));
        }
    }
}

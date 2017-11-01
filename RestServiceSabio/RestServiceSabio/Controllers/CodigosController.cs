using System;
using Microsoft.AspNetCore.Mvc;
using RestServiceSabio.Model;
using RestServiceSabio.Managers;

namespace RestServiceSabio.Controllers
{
    [Route("api/[controller]")]
    public class CodigosController : Controller
    {
        private CodBarraManager codBarraManager = new CodBarraManager();
        private SessionManager sessionManager = new SessionManager();
        private Usuario user = new Usuario();
        // GET api/session/login/juan
        [HttpGet("get/{userId}")]
        public IActionResult GetCodigos(String userId)
        {
            user.loginUsuario = userId;
            int estado = sessionManager.estadoSesion(user);
            if (estado == 1)
            {
                return Ok(codBarraManager.obtenerTodos());
            }
            else
            {
                return BadRequest("No es posible obtener los codigos de barra, el usuario no esta logueado");
            }
        }
    }
}
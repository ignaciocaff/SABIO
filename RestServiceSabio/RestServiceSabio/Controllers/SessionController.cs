using System;
using Microsoft.AspNetCore.Mvc;
using RestServiceSabio.Managers;
using RestServiceSabio.Model;

namespace RestServiceSabio.Controllers
{
    [Route("api/[controller]")]
    public class SessionController : Controller
    {
        private SessionManager sessionManager = new SessionManager();
        private Usuario user = new Usuario();
        // GET api/session/login/juan
        [HttpPost("login/{userId}")]
        public IActionResult PostLogIn(String userId, [FromBody]DatosLog datosLog)
        {
            user.loginUsuario = userId;
            int estado = sessionManager.estadoSesion(user);
            if (estado == 0)
            {
                return Ok(sessionManager.logIn(user, datosLog));
            }
            else
            {
                return BadRequest("El usuario ya se encuentra logueado");
            }
        }

        // GET api/session/logout/juan
        [HttpPost("logout/{userId}")]
        public IActionResult PostLogOut(String userId, [FromBody]DatosLog datosLog)
        {
            user.loginUsuario = userId;
            int estado = sessionManager.estadoSesion(user);
            if (estado == 1)
            {
                return Ok(sessionManager.logOut(user, datosLog));
            }
            else
            {
                return BadRequest("El usuario ya se encuentra deslogueado");
            }
        }
    }
}

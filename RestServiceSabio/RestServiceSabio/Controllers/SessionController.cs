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
        [HttpGet("login/{userId}")]
        public IActionResult GetLogIn(String userId)
        {
            user.loginUsuario = userId;
            int estado = sessionManager.estadoSesion(user);
            if(estado == 0){
                return Ok(sessionManager.logIn(user));
            }else{
                return BadRequest("El usuario ya se encuentra logueado");
            }
        }

        // GET api/session/logout/juan
        [HttpGet("logout/{userId}")]
        public IActionResult GetLogOut(String userId)
        {
            user.loginUsuario = userId;
            int estado = sessionManager.estadoSesion(user);
            if(estado == 1){
                return Ok(sessionManager.logOut(user));
            }else{
                return BadRequest("El usuario ya se encuentra deslogueado");
            }
        }

        // POST api/session
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/session/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/session/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

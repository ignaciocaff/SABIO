using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestServiceSabio.Model
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public String loginUsuario { get; set; }
        public int estado { get; set; }
        public String nombre { get; set; }
        public int area { get; set; }
        public int deposito { get; set; }
    }
}

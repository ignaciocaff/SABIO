using RestServiceSabio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestServiceSabio.Managers
{
    public class UpdateManager
    {
        SabioDbContext context = new SabioDbContext();
        private const String parametroUpdate = "DROIDUPDAT";
        public Boolean existenUpdates()
        {
            int update = (int)context.Parametros.Where(x => x.Codigo == parametroUpdate).Select(y => y.Boole1).FirstOrDefault();
            return Convert.ToBoolean(update);
        }

        public System.Object obtenerArticulos()
        {
            try
            {
                var listadoArticulos = context.Articulos.Select(x => new { x.Codigo, x.Descri }).ToList();
                if (listadoArticulos != null && listadoArticulos.Count > 0)
                {
                    context.Parametros.Where(x => x.Codigo == parametroUpdate).ToList().ForEach(y => y.Boole1 = 0);
                    context.SaveChanges();
                }
                return listadoArticulos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }
    }
}

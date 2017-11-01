using System;

namespace RestServiceSabio.Model
{
    public class CodigoBarra
    {
        public int numero { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public int largoTotal { get; set; }
        public int ubicacionCodProd { get; set; }
        public int largoCodProd { get; set; }
        public int ubicacionCantidad { get; set; }
        public int largoCantidad { get; set; }
        public int ubicacionPeso { get; set; }
        public int largoPeso { get; set; }
        public int ubicacionPrecio { get; set; }
        public int largoPrecio { get; set; }
        public int ubicacionFechaElab { get; set; }
        public int largoFechaElab { get; set; }
        public int ubicacionFechaVenc { get; set; }
        public int largoFechaVenc { get; set; }
        public int ubicacionDigitoVer { get; set; }
        public int largoDigitoVer { get; set; }
        public int ubicacionIdUsuario { get; set; }
        public int largoIdUsuario { get; set; }
        public int cantidadDecPeso { get; set; }

    }
}

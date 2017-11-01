using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("IMG_CUENTAS")]
    public partial class ImgCuentas
    {
        [Column("CUENTA")]
        public int Cuenta { get; set; }
        [Column("IMAGEN")]
        public int Imagen { get; set; }
    }
}

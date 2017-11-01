using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TIPO_PRODUCTO")]
    public partial class TipoProducto
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("CODIGO")]
        [StringLength(10)]
        public string Codigo { get; set; }
        [Column("CODAFI")]
        public short? Codafi { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ARTICULOS_X_PROVEEDOR")]
    public partial class ArticulosXProveedor
    {
        [Column("ARTICU")]
        [StringLength(20)]
        public string Articu { get; set; }
        [Column("PROVEE")]
        public int Provee { get; set; }
        [Column("PROCES")]
        public short Proces { get; set; }
        [Column("STRDES")]
        [StringLength(20)]
        public string Strdes { get; set; }
    }
}

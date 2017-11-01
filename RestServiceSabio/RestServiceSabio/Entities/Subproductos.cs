using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("SUBPRODUCTOS")]
    public partial class Subproductos
    {
        [Column("PRODUC")]
        [StringLength(20)]
        public string Produc { get; set; }
        [Column("SUBPRO")]
        [StringLength(20)]
        public string Subpro { get; set; }
    }
}

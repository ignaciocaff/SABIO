using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ITEMS")]
    public partial class Items
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("CODIGO")]
        public short? Codigo { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
    }
}

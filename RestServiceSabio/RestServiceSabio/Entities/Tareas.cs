using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TAREAS")]
    public partial class Tareas
    {
        [Key]
        [Column("CODIGO")]
        [StringLength(10)]
        public string Codigo { get; set; }
        [Column("DESCRI")]
        [StringLength(40)]
        public string Descri { get; set; }
        [Column("UNIDAD")]
        public short? Unidad { get; set; }
        [Column("ITEMS")]
        public short? Items { get; set; }
        [Column("ORDEN")]
        [StringLength(20)]
        public string Orden { get; set; }
    }
}

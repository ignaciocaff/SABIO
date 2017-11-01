using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MATERIALES")]
    public partial class Materiales
    {
        [Key]
        [Column("CODIGO")]
        [StringLength(10)]
        public string Codigo { get; set; }
        [Column("DESCRI")]
        [StringLength(40)]
        public string Descri { get; set; }
        [Column("RUBRO")]
        public short? Rubro { get; set; }
        [Column("UNIDAD")]
        public short? Unidad { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
    }
}

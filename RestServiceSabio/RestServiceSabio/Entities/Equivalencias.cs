using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("EQUIVALENCIAS")]
    public partial class Equivalencias
    {
        [Column("IDGRUP")]
        public int Idgrup { get; set; }
        [Column("CODIGO")]
        [StringLength(20)]
        public string Codigo { get; set; }
        [Column("DESCRI")]
        [StringLength(250)]
        public string Descri { get; set; }
        [Column("ORDEN")]
        public short? Orden { get; set; }
        [Column("NOMGRU")]
        [StringLength(250)]
        public string Nomgru { get; set; }
        [Column("MARCA")]
        [StringLength(40)]
        public string Marca { get; set; }
    }
}

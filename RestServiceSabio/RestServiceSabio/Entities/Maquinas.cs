using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MAQUINAS")]
    public partial class Maquinas
    {
        [Key]
        [Column("CODIGO")]
        [StringLength(20)]
        public string Codigo { get; set; }
        [Column("DESCRI")]
        [StringLength(60)]
        public string Descri { get; set; }
        [Column("MODELO")]
        public short? Modelo { get; set; }
        [Column("TIPO")]
        public short? Tipo { get; set; }
    }
}

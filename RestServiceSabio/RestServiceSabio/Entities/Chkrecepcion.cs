using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CHKRECEPCION")]
    public partial class Chkrecepcion
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("TIPO")]
        public short? Tipo { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("CHEKEA")]
        public short? Chekea { get; set; }
        [Column("DESCRI")]
        [StringLength(250)]
        public string Descri { get; set; }
    }
}

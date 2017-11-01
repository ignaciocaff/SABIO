using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TARJETAS")]
    public partial class Tarjetas
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("DESCRI")]
        [StringLength(40)]
        public string Descri { get; set; }
        [Column("TIPO")]
        public short Tipo { get; set; }
        [Column("CUENTA")]
        public int Cuenta { get; set; }
        [Column("CTACON", TypeName = "CHAR(12) CHARACTER SET NONE")]
        public string Ctacon { get; set; }
        [Column("DIAPAG")]
        public short? Diapag { get; set; }
        [Column("FECCIE")]
        public short? Feccie { get; set; }
        [Column("FECPAG")]
        public short? Fecpag { get; set; }
    }
}

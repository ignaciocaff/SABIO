using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETRETENCIONES")]
    public partial class Detretenciones
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("ASIENT")]
        public int Asient { get; set; }
        [Column("REGLON")]
        public short Reglon { get; set; }
        [Required]
        [Column("COMPRO")]
        [StringLength(3)]
        public string Compro { get; set; }
        [Column("DESCRI")]
        [StringLength(40)]
        public string Descri { get; set; }
        [Column("OBSERV", TypeName = "VARCHAR(10240)")]
        public string Observ { get; set; }
        [Column("NUMERO")]
        [StringLength(40)]
        public string Numero { get; set; }

        [ForeignKey("Asient")]
        [InverseProperty("Detretenciones")]
        public Movcontables AsientNavigation { get; set; }
    }
}

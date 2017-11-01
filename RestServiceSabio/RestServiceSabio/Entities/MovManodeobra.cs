using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOV_MANODEOBRA")]
    public partial class MovManodeobra
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("PROVEE")]
        public int Provee { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Column("NROCOM")]
        public int? Nrocom { get; set; }
        [Column("OBSERV")]
        [StringLength(100)]
        public string Observ { get; set; }
        [Column("PRESUP")]
        public int Presup { get; set; }
        [Column("NUMASI")]
        public short? Numasi { get; set; }
        [Column("ASIENT")]
        public int? Asient { get; set; }

        [ForeignKey("Asient")]
        [InverseProperty("MovManodeobra")]
        public Movcontables AsientNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOVCHEQUES3")]
    public partial class Movcheques3
    {
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("ASIENT")]
        public int Asient { get; set; }
        [Column("REGLON")]
        public short Reglon { get; set; }
        [Column("FECHA")]
        public DateTime Fecha { get; set; }
        [Column("ESTADO")]
        public short Estado { get; set; }
        [Column("CAJA")]
        public int Caja { get; set; }

        [ForeignKey("Numint")]
        [InverseProperty("Movcheques3")]
        public Cheques3 NumintNavigation { get; set; }
    }
}

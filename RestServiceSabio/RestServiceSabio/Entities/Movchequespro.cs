using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOVCHEQUESPRO")]
    public partial class Movchequespro
    {
        [Column("CHEQUE")]
        public short Cheque { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
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

        [ForeignKey("Cheque,Numero")]
        [InverseProperty("Movchequespro")]
        public Chequespro Chequespro { get; set; }
    }
}

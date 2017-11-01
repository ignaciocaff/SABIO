using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("NEGO_CONTABLES")]
    public partial class NegoContables
    {
        [Column("NEGOCI")]
        public int Negoci { get; set; }
        [Column("ASIENT")]
        public int Asient { get; set; }
        [Column("REGLON")]
        public short Reglon { get; set; }

        [ForeignKey("Asient,Reglon")]
        [InverseProperty("NegoContables")]
        public Detmovcontables Detmovcontables { get; set; }
    }
}

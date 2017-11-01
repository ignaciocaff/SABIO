using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOVSERIALESCONTABLES")]
    public partial class Movserialescontables
    {
        [Column("ASIENT")]
        public int Asient { get; set; }
        [Column("REGLON")]
        public short Reglon { get; set; }
        [Column("NROSER")]
        public int Nroser { get; set; }

        [ForeignKey("Asient,Reglon")]
        [InverseProperty("Movserialescontables")]
        public Detmovcontables Detmovcontables { get; set; }
    }
}

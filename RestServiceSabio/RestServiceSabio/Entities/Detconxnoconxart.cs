using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETCONXNOCONXART")]
    public partial class Detconxnoconxart
    {
        [Column("ASIENT")]
        public int Asient { get; set; }
        [Column("REGLON")]
        public short Reglon { get; set; }
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("ORICON")]
        public short? Oricon { get; set; }

        [ForeignKey("Asient,Reglon")]
        [InverseProperty("Detconxnoconxart")]
        public Detmovcontables Detmovcontables { get; set; }
        [ForeignKey("Numint")]
        [InverseProperty("Detconxnoconxart")]
        public Detmovnoconart NumintNavigation { get; set; }
    }
}

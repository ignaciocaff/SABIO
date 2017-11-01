using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ASIXCAJA")]
    public partial class Asixcaja
    {
        [Column("ASIENT")]
        public int Asient { get; set; }
        [Column("NROMOV")]
        public int Nromov { get; set; }

        [ForeignKey("Nromov")]
        [InverseProperty("Asixcaja")]
        public Movcajas NromovNavigation { get; set; }
    }
}

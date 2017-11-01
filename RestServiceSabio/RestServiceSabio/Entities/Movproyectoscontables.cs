using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOVPROYECTOSCONTABLES")]
    public partial class Movproyectoscontables
    {
        [Column("PROYEC")]
        public int Proyec { get; set; }
        [Column("ASIENT")]
        public int Asient { get; set; }

        [ForeignKey("Asient")]
        [InverseProperty("Movproyectoscontables")]
        public Movcontables AsientNavigation { get; set; }
    }
}

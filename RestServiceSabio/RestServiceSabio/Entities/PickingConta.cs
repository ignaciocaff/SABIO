using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PICKING_CONTA")]
    public partial class PickingConta
    {
        [Column("NROPIC")]
        public int Nropic { get; set; }
        [Column("ASIENT")]
        public int Asient { get; set; }

        [ForeignKey("Asient")]
        [InverseProperty("PickingConta")]
        public Movcontables AsientNavigation { get; set; }
    }
}

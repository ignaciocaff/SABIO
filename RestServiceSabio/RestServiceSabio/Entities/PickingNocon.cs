using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PICKING_NOCON")]
    public partial class PickingNocon
    {
        [Column("NROPIC")]
        public int Nropic { get; set; }
        [Column("NOCONT")]
        public int Nocont { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PICKING_USER")]
    public partial class PickingUser
    {
        [Column("NROPIC")]
        public int Nropic { get; set; }
        [Column("USUARI")]
        public short Usuari { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PERUSUARIOS")]
    public partial class Perusuarios
    {
        [Column("CASOUS")]
        [StringLength(10)]
        public string Casous { get; set; }
        [Column("USUARI")]
        public short Usuari { get; set; }
        [Column("HABILI")]
        public short Habili { get; set; }
    }
}

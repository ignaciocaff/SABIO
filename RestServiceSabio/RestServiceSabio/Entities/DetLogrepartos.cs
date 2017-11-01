using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DET_LOGREPARTOS")]
    public partial class DetLogrepartos
    {
        [Column("NUMRTO")]
        public int Numrto { get; set; }
        [Column("IDPEDI")]
        public int Idpedi { get; set; }
        [Column("VEHICU")]
        public short Vehicu { get; set; }
    }
}

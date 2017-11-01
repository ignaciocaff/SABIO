using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DET_PRE_X_MAT")]
    public partial class DetPreXMat
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("MATERI")]
        [StringLength(10)]
        public string Materi { get; set; }
        [Column("DEPRET")]
        public int? Depret { get; set; }
        [Column("RUBRO")]
        public short? Rubro { get; set; }
        [Column("UNIDAD")]
        public short? Unidad { get; set; }
    }
}

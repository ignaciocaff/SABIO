using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOV_ARTICULOS")]
    public partial class MovArticulos
    {
        public MovArticulos()
        {
            DetMovArticulos = new HashSet<DetMovArticulos>();
        }

        [Key]
        [Column("NROINT")]
        public int Nroint { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Required]
        [Column("COMPRO", TypeName = "CHAR(3) CHARACTER SET NONE")]
        public string Compro { get; set; }
        [Column("NROCOM")]
        [StringLength(13)]
        public string Nrocom { get; set; }
        [Column("DEPOSI")]
        public short Deposi { get; set; }
        [Column("RESPON")]
        public short Respon { get; set; }
        [Column("NROCON")]
        public int? Nrocon { get; set; }
        [Column("INTDEP")]
        public int? Intdep { get; set; }
        [Column("NRODEP")]
        public short? Nrodep { get; set; }

        [InverseProperty("NrointNavigation")]
        public ICollection<DetMovArticulos> DetMovArticulos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DET_MOV_ARTICULOS")]
    public partial class DetMovArticulos
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("NROINT")]
        public int? Nroint { get; set; }
        [Column("ARTICU")]
        [StringLength(20)]
        public string Articu { get; set; }
        [Column("CTRCOM")]
        public int? Ctrcom { get; set; }
        [Column("TRANID")]
        public int? Tranid { get; set; }

        [ForeignKey("Nroint")]
        [InverseProperty("DetMovArticulos")]
        public MovArticulos NrointNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PESAJES")]
    public partial class Pesajes
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("NUMVEH")]
        public short Numveh { get; set; }
        [Column("NUMTRA")]
        public int Numtra { get; set; }
        [Column("NUMCHO")]
        public short Numcho { get; set; }
        [Column("CTACTE")]
        public int Ctacte { get; set; }
        [Column("FECTAR", TypeName = "DATE")]
        public DateTime? Fectar { get; set; }
        [Column("HORTAR", TypeName = "TIME")]
        public DateTime? Hortar { get; set; }
        [Column("FECBRU", TypeName = "DATE")]
        public DateTime? Fecbru { get; set; }
        [Column("HORBRU", TypeName = "TIME")]
        public DateTime? Horbru { get; set; }
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
        [Column("ANULAD")]
        public short? Anulad { get; set; }
        [Column("NUMREM")]
        public int? Numrem { get; set; }
        [Column("LUGCAR")]
        public short Lugcar { get; set; }
    }
}

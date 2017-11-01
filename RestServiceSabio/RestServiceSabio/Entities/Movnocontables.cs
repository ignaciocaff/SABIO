using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOVNOCONTABLES")]
    public partial class Movnocontables
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Required]
        [Column("COMPRO", TypeName = "CHAR(3) CHARACTER SET NONE")]
        public string Compro { get; set; }
        [Column("NROCOM")]
        [StringLength(13)]
        public string Nrocom { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Column("FECVEN", TypeName = "DATE")]
        public DateTime? Fecven { get; set; }
        [Column("CTACTE")]
        public int Ctacte { get; set; }
        [Column("ATENCI")]
        [StringLength(40)]
        public string Atenci { get; set; }
        [Column("MONEDA")]
        public short? Moneda { get; set; }
        [Column("UNINEG")]
        public short? Unineg { get; set; }
        [Column("OBSERV", TypeName = "VARCHAR(10240)")]
        public string Observ { get; set; }
        [Column("STRDES")]
        [StringLength(20)]
        public string Strdes { get; set; }
        [Column("FORPAG")]
        public short? Forpag { get; set; }
        [Column("LISPRE")]
        public short? Lispre { get; set; }
        [Column("VENDED")]
        public short? Vended { get; set; }
        [Column("RESPON")]
        public short Respon { get; set; }
        [Column("DEPOSI")]
        public short Deposi { get; set; }
        [Column("NUMORI")]
        public int? Numori { get; set; }
        [Column("DEPORI")]
        public short? Depori { get; set; }
        [Column("FECANU", TypeName = "DATE")]
        public DateTime? Fecanu { get; set; }
        [Column("ESTADO")]
        public short Estado { get; set; }
        [Column("NRODES")]
        [StringLength(40)]
        public string Nrodes { get; set; }
        [Column("TEXTO1")]
        [StringLength(250)]
        public string Texto1 { get; set; }
        [Column("TEXTO2")]
        [StringLength(250)]
        public string Texto2 { get; set; }
        [Column("HORA", TypeName = "TIME")]
        public DateTime? Hora { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("COMPROBANTES")]
    public partial class Comprobantes
    {
        [Key]
        [Column("CODIGO")]
        [StringLength(3)]
        public string Codigo { get; set; }
        [Required]
        [Column("DESCRI")]
        [StringLength(40)]
        public string Descri { get; set; }
        [Column("TIPO")]
        public short Tipo { get; set; }
        [Column("AFESAL")]
        public short Afesal { get; set; }
        [Required]
        [Column("SIGNO")]
        [StringLength(1)]
        public string Signo { get; set; }
        [Column("AFESTK")]
        public short Afestk { get; set; }
        [Required]
        [Column("SIGSTK")]
        [StringLength(1)]
        public string Sigstk { get; set; }
        [Column("ETIQUE")]
        [StringLength(3)]
        public string Etique { get; set; }
        [Column("TITULO")]
        [StringLength(40)]
        public string Titulo { get; set; }
        [Column("CAPTIO")]
        [StringLength(40)]
        public string Captio { get; set; }
        [Column("LABEL")]
        [StringLength(40)]
        public string Label { get; set; }
        [Column("LIBIVA")]
        public short Libiva { get; set; }
        [Column("DEDUCC")]
        public short Deducc { get; set; }
        [Column("TIPCUE")]
        public short Tipcue { get; set; }
        [Column("DETALL")]
        public short Detall { get; set; }
        [Column("APLICA")]
        public short Aplica { get; set; }
        [Column("FORPAG")]
        public short Forpag { get; set; }
        [Column("COMPOR")]
        [StringLength(1024)]
        public string Compor { get; set; }
        [Column("OBSER1", TypeName = "VARCHAR(10240)")]
        public string Obser1 { get; set; }
        [Column("OBSER2", TypeName = "VARCHAR(10240)")]
        public string Obser2 { get; set; }
        [Column("OBSER3", TypeName = "VARCHAR(10240)")]
        public string Obser3 { get; set; }
        [Column("PERCEP")]
        public short? Percep { get; set; }
        [Column("RETENC")]
        public short? Retenc { get; set; }
        [Column("TIPNUM")]
        public short Tipnum { get; set; }
        [Column("LETRA", TypeName = "CHAR(1) CHARACTER SET NONE")]
        public string Letra { get; set; }
        [Column("CONTRA", TypeName = "CHAR(3) CHARACTER SET NONE")]
        public string Contra { get; set; }
        [Column("TABLA")]
        [StringLength(20)]
        public string Tabla { get; set; }
        [Column("ESTILO")]
        public short? Estilo { get; set; }
        [Column("CPRSTK")]
        public short? Cprstk { get; set; }
        [Column("SIGCPR")]
        [StringLength(1)]
        public string Sigcpr { get; set; }
        [Column("PRESUP")]
        public short? Presup { get; set; }
        [Column("AFEREA")]
        public short? Aferea { get; set; }
        [Column("SIGREA")]
        [StringLength(1)]
        public string Sigrea { get; set; }
    }
}

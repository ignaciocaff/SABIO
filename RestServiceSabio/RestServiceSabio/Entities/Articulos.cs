using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ARTICULOS")]
    public partial class Articulos
    {
        [Key]
        [Column("CODIGO")]
        [StringLength(20)]
        public string Codigo { get; set; }
        [Column("CODBAR")]
        [StringLength(20)]
        public string Codbar { get; set; }
        [Column("CODABR")]
        [StringLength(20)]
        public string Codabr { get; set; }
        [Column("SUBRUB")]
        public short Subrub { get; set; }
        [Column("TIPPRO")]
        public short? Tippro { get; set; }
        [Column("OBSERV", TypeName = "VARCHAR(10240)")]
        public string Observ { get; set; }
        [Column("MUESTK")]
        public short? Muestk { get; set; }
        [Column("MODELO")]
        public int? Modelo { get; set; }
        [Column("PERFIL")]
        public short? Perfil { get; set; }
        [Column("UNIDAD")]
        public short? Unidad { get; set; }
        [Column("FECALT", TypeName = "DATE")]
        public DateTime? Fecalt { get; set; }
        [Column("TIPMOV")]
        public short Tipmov { get; set; }
        [Column("MONEDA")]
        public short? Moneda { get; set; }
        [Column("STRUTI")]
        [StringLength(20)]
        public string Struti { get; set; }
        [Column("UBICAC")]
        public short? Ubicac { get; set; }
        [Column("ESCOMP")]
        public short? Escomp { get; set; }
        [Column("TIPCOM")]
        public short? Tipcom { get; set; }
        [Column("CONSER")]
        public short? Conser { get; set; }
        [Column("GTACOM")]
        public short? Gtacom { get; set; }
        [Column("GTAVTA")]
        public short? Gtavta { get; set; }
        [Column("PRESEN")]
        public short Presen { get; set; }
        [Column("CALCAN")]
        public short? Calcan { get; set; }
        [Column("MUELIS")]
        public short? Muelis { get; set; }
        [Column("FECMOD")]
        public DateTime? Fecmod { get; set; }
        [Column("CODMTX")]
        [StringLength(20)]
        public string Codmtx { get; set; }
        [Column("CODAFI")]
        [StringLength(10)]
        public string Codafi { get; set; }
        [Column("DESCRI")]
        [StringLength(250)]
        public string Descri { get; set; }
    }
}

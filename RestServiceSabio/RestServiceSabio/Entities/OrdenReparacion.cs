using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ORDEN_REPARACION")]
    public partial class OrdenReparacion
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("CUENTA")]
        public int? Cuenta { get; set; }
        [Column("USUREC")]
        public short? Usurec { get; set; }
        [Column("SUCORI")]
        public short? Sucori { get; set; }
        [Column("CODMAQ")]
        [StringLength(20)]
        public string Codmaq { get; set; }
        [Column("NROSER")]
        [StringLength(20)]
        public string Nroser { get; set; }
        [Column("DESFAL")]
        [StringLength(2048)]
        public string Desfal { get; set; }
        [Column("GARANT")]
        public short? Garant { get; set; }
        [Column("GARFAC")]
        [StringLength(15)]
        public string Garfac { get; set; }
        [Column("GARFEC", TypeName = "DATE")]
        public DateTime? Garfec { get; set; }
        [Column("GARNUM")]
        [StringLength(20)]
        public string Garnum { get; set; }
        [Column("GARCOM")]
        public int? Garcom { get; set; }
        [Column("GARFOT")]
        public short? Garfot { get; set; }
        [Column("FECENT", TypeName = "DATE")]
        public DateTime? Fecent { get; set; }
        [Column("OBSERV")]
        [StringLength(1024)]
        public string Observ { get; set; }
        [Column("TECNIC")]
        public short Tecnic { get; set; }
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
        [Column("DESCRI")]
        [StringLength(60)]
        public string Descri { get; set; }
        [Column("NUMORI")]
        public int? Numori { get; set; }
        [Column("NUMSST")]
        [StringLength(10)]
        public string Numsst { get; set; }
        [Column("NUMASI")]
        public int? Numasi { get; set; }
        [Column("TABLA")]
        [StringLength(20)]
        public string Tabla { get; set; }
        [Column("HORENT", TypeName = "TIME")]
        public DateTime? Horent { get; set; }
        [Column("FECINI", TypeName = "DATE")]
        public DateTime? Fecini { get; set; }
        [Column("HORINI", TypeName = "TIME")]
        public DateTime? Horini { get; set; }
        [Column("CONTAC")]
        [StringLength(40)]
        public string Contac { get; set; }
        [Column("CANTUR")]
        public short? Cantur { get; set; }
    }
}

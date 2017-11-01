using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ESTILOIMPRESION")]
    public partial class Estiloimpresion
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("TIPIMP")]
        public short Tipimp { get; set; }
        [Required]
        [Column("TABLA")]
        [StringLength(20)]
        public string Tabla { get; set; }
        [Column("ORIENT")]
        public short Orient { get; set; }
        [Column("TIPHOJ")]
        public short Tiphoj { get; set; }
        [Column("HLEFT")]
        public float? Hleft { get; set; }
        [Column("HRIGHT")]
        public float? Hright { get; set; }
        [Column("HTOP")]
        public float? Htop { get; set; }
        [Column("HBOTTO")]
        public float? Hbotto { get; set; }
        [Column("GENRET")]
        public short? Genret { get; set; }
        [Column("RPTXML", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Rptxml { get; set; }
        [Column("TIPCOM")]
        public short Tipcom { get; set; }
    }
}

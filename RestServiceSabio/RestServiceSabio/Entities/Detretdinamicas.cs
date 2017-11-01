using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETRETDINAMICAS")]
    public partial class Detretdinamicas
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("CODIGO")]
        [StringLength(20)]
        public string Codigo { get; set; }
        [Column("ORDEN")]
        public short Orden { get; set; }
        [Column("TIPO")]
        public short Tipo { get; set; }
        [Column("FORMUL", TypeName = "VARCHAR(10240)")]
        public string Formul { get; set; }
        [Required]
        [Column("COMPRO", TypeName = "CHAR(3) CHARACTER SET NONE")]
        public string Compro { get; set; }
        [Column("IMPRIM")]
        public short? Imprim { get; set; }

        [ForeignKey("Codigo")]
        [InverseProperty("Detretdinamicas")]
        public CodigosRetenciones CodigoNavigation { get; set; }
    }
}

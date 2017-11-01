using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETRETMOV")]
    public partial class Detretmov
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("NUMRET")]
        public int Numret { get; set; }
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
        [Column("VALOR")]
        [StringLength(20)]
        public string Valor { get; set; }
        [Column("IMPRIM")]
        public short? Imprim { get; set; }

        [ForeignKey("Codigo")]
        [InverseProperty("Detretmov")]
        public CodigosRetenciones CodigoNavigation { get; set; }
    }
}

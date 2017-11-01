using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CONCEPTOS_CASH")]
    public partial class ConceptosCash
    {
        [Required]
        [Column("CODIGO")]
        [StringLength(10)]
        public string Codigo { get; set; }
        [Column("DESCRI")]
        [StringLength(40)]
        public string Descri { get; set; }
        [Column("TIPO")]
        public short Tipo { get; set; }
        [Column("GRUPO")]
        public short Grupo { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Column("FORMUL")]
        [StringLength(200)]
        public string Formul { get; set; }
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }

        [ForeignKey("Codigo")]
        [InverseProperty("ConceptosCash")]
        public CodigosCash CodigoNavigation { get; set; }
    }
}

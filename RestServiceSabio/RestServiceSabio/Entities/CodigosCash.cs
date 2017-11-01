using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CODIGOS_CASH")]
    public partial class CodigosCash
    {
        public CodigosCash()
        {
            ConceptosCash = new HashSet<ConceptosCash>();
        }

        [Key]
        [Column("CODIGO")]
        [StringLength(10)]
        public string Codigo { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }

        [InverseProperty("CodigoNavigation")]
        public ICollection<ConceptosCash> ConceptosCash { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CODIGOS_RETENCIONES")]
    public partial class CodigosRetenciones
    {
        public CodigosRetenciones()
        {
            Detretdinamicas = new HashSet<Detretdinamicas>();
            Detretmov = new HashSet<Detretmov>();
        }

        [Key]
        [Column("CODIGO")]
        [StringLength(20)]
        public string Codigo { get; set; }
        [Column("DESCRI")]
        [StringLength(40)]
        public string Descri { get; set; }

        [InverseProperty("CodigoNavigation")]
        public ICollection<Detretdinamicas> Detretdinamicas { get; set; }
        [InverseProperty("CodigoNavigation")]
        public ICollection<Detretmov> Detretmov { get; set; }
    }
}

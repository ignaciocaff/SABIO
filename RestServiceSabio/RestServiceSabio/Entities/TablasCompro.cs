using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TABLAS_COMPRO")]
    public partial class TablasCompro
    {
        [Key]
        [Column("CODIGO")]
        [StringLength(20)]
        public string Codigo { get; set; }
        [Column("DESCRI")]
        [StringLength(40)]
        public string Descri { get; set; }
    }
}

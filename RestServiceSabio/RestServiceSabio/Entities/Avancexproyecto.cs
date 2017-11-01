using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("AVANCEXPROYECTO")]
    public partial class Avancexproyecto
    {
        [Column("PROYEC")]
        public int Proyec { get; set; }
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
    }
}

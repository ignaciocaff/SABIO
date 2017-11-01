using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("OFERTA")]
    public partial class Oferta
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("SUFIJO")]
        [StringLength(40)]
        public string Sufijo { get; set; }
        [Column("DESDE", TypeName = "DATE")]
        public DateTime? Desde { get; set; }
        [Column("HASTA", TypeName = "DATE")]
        public DateTime? Hasta { get; set; }
    }
}

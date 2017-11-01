using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TIPOMOV")]
    public partial class Tipomov
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Required]
        [Column("CTAING")]
        [StringLength(12)]
        public string Ctaing { get; set; }
        [Required]
        [Column("CTAEGR")]
        [StringLength(12)]
        public string Ctaegr { get; set; }
        [Column("CENCOS")]
        public short Cencos { get; set; }
    }
}

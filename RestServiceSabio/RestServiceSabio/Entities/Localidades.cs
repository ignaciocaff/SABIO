using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("LOCALIDADES")]
    public partial class Localidades
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("CODPOS")]
        [StringLength(10)]
        public string Codpos { get; set; }
        [Column("PROVIN")]
        public short Provin { get; set; }
        [Column("PAIS")]
        public short Pais { get; set; }
    }
}

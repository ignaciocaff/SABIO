using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOVESTADOSDES")]
    public partial class Movestadosdes
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Required]
        [Column("CODDES")]
        [StringLength(100)]
        public string Coddes { get; set; }
        [Column("ESTADO")]
        public short Estado { get; set; }
        [Column("OBSERV")]
        [StringLength(200)]
        public string Observ { get; set; }
    }
}

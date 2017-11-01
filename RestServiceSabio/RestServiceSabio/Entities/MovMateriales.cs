using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOV_MATERIALES")]
    public partial class MovMateriales
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("MATERI")]
        [StringLength(10)]
        public string Materi { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Column("NROCOM")]
        public int? Nrocom { get; set; }
        [Column("OBSERV")]
        [StringLength(100)]
        public string Observ { get; set; }
        [Column("PRESUP")]
        public int Presup { get; set; }
    }
}

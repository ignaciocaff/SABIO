using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ASIGNACION_MANODEOBRA")]
    public partial class AsignacionManodeobra
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("PROVEE")]
        public int Provee { get; set; }
        [Column("OBSERV")]
        [StringLength(100)]
        public string Observ { get; set; }
        [Column("PRESUP")]
        public int Presup { get; set; }
        [Column("NUMASI")]
        public int Numasi { get; set; }
    }
}

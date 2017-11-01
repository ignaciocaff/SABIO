using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DET_PRESUPUESTOS_X_TAREAS")]
    public partial class DetPresupuestosXTareas
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("PRESUP")]
        public int? Presup { get; set; }
        [Column("TAREA")]
        [StringLength(10)]
        public string Tarea { get; set; }
        [Column("UNIDAD")]
        public short? Unidad { get; set; }
        [Column("OBSERV")]
        [StringLength(40)]
        public string Observ { get; set; }
        [Column("DIM")]
        public double? Dim { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DET_TAREAS")]
    public partial class DetTareas
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("TAREA")]
        [StringLength(10)]
        public string Tarea { get; set; }
        [Column("MATERI")]
        [StringLength(10)]
        public string Materi { get; set; }
    }
}

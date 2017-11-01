using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PROCESOS_ART")]
    public partial class ProcesosArt
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("ESEXTE")]
        public short? Esexte { get; set; }
        [Column("SUMSTK")]
        public short? Sumstk { get; set; }
    }
}

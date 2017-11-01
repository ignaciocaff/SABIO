using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TURNOS_LUB")]
    public partial class TurnosLub
    {
        [Column("FECHA")]
        public DateTime Fecha { get; set; }
        [Column("HORA", TypeName = "TIME")]
        public DateTime Hora { get; set; }
        [Column("FOSA")]
        public short Fosa { get; set; }
        [Column("VEHICU")]
        public short Vehicu { get; set; }
    }
}

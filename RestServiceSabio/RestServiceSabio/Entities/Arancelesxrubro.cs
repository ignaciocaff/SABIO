using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ARANCELESXRUBRO")]
    public partial class Arancelesxrubro
    {
        [Column("TIPOAR")]
        public short Tipoar { get; set; }
        [Column("RUBRO")]
        public short Rubro { get; set; }
    }
}

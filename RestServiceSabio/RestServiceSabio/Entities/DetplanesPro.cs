using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETPLANES_PRO")]
    public partial class DetplanesPro
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("NUMPLA")]
        public int? Numpla { get; set; }
        [Column("NUMPED")]
        public int? Numped { get; set; }
        [Column("ESEXTE")]
        public short? Esexte { get; set; }
        [Column("NUMPRO")]
        public short? Numpro { get; set; }
        [Column("PROVEE")]
        public int? Provee { get; set; }
    }
}

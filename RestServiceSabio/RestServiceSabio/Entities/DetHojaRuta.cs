using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DET_HOJA_RUTA")]
    public partial class DetHojaRuta
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("NROHOJ")]
        public int Nrohoj { get; set; }
        [Column("PRIORI")]
        public short? Priori { get; set; }
        [Column("ORDEN")]
        public short? Orden { get; set; }
        [Column("NROBUL")]
        public int Nrobul { get; set; }
        [Column("HORARI")]
        [StringLength(100)]
        public string Horari { get; set; }
        [Column("OBSERV")]
        [StringLength(100)]
        public string Observ { get; set; }
        [Column("GEOLOC")]
        [StringLength(100)]
        public string Geoloc { get; set; }
        [Column("CHKLIS")]
        public short? Chklis { get; set; }
    }
}

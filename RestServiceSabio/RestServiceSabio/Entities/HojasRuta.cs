using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("HOJAS_RUTA")]
    public partial class HojasRuta
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("FECINI", TypeName = "DATE")]
        public DateTime? Fecini { get; set; }
        [Column("HORINI", TypeName = "TIME")]
        public DateTime? Horini { get; set; }
        [Column("ESTADO")]
        public short Estado { get; set; }
        [Column("VEHICU")]
        public short Vehicu { get; set; }
        [Column("CHOFER")]
        public short Chofer { get; set; }
        [Column("USUARI")]
        public short Usuari { get; set; }
        [Column("FECFIN", TypeName = "DATE")]
        public DateTime? Fecfin { get; set; }
        [Column("HORFIN", TypeName = "TIME")]
        public DateTime? Horfin { get; set; }
        [Column("OBSERV")]
        [StringLength(256)]
        public string Observ { get; set; }
        [Column("URLMAP", TypeName = "VARCHAR(20480)")]
        public string Urlmap { get; set; }
        [Column("INTERN")]
        public short? Intern { get; set; }
    }
}

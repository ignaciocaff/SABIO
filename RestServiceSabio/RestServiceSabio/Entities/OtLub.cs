using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("OT_LUB")]
    public partial class OtLub
    {
        [Column("NOCONT")]
        public int Nocont { get; set; }
        [Column("VEHICU")]
        public short Vehicu { get; set; }
        [Column("KM_SER")]
        public int? KmSer { get; set; }
        [Column("KM_PRO")]
        public int? KmPro { get; set; }
        [Column("FECSER", TypeName = "DATE")]
        public DateTime? Fecser { get; set; }
        [Column("FECPRO", TypeName = "DATE")]
        public DateTime? Fecpro { get; set; }
        [Column("AVISA")]
        public short? Avisa { get; set; }
        [Column("TIP_KM")]
        public short? TipKm { get; set; }
    }
}

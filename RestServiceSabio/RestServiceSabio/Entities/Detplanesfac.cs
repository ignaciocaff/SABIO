using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETPLANESFAC")]
    public partial class Detplanesfac
    {
        [Column("CTACTE")]
        public int Ctacte { get; set; }
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
        [Column("FECVEN", TypeName = "DATE")]
        public DateTime? Fecven { get; set; }
        [Column("PARADO")]
        public short? Parado { get; set; }
        [Column("CONCEP")]
        [StringLength(250)]
        public string Concep { get; set; }
        [Column("FACSOL")]
        public short? Facsol { get; set; }
    }
}

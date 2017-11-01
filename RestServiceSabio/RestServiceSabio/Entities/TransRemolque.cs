using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TRANS_REMOLQUE")]
    public partial class TransRemolque
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("DESCRI")]
        [StringLength(40)]
        public string Descri { get; set; }
        [Column("SEGURO")]
        [StringLength(40)]
        public string Seguro { get; set; }
        [Column("POLIZA")]
        [StringLength(40)]
        public string Poliza { get; set; }
        [Column("DOMINI")]
        [StringLength(20)]
        public string Domini { get; set; }
        [Column("NUMIDE")]
        public short Numide { get; set; }
    }
}

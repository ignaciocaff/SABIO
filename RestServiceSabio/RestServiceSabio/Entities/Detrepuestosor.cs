using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETREPUESTOSOR")]
    public partial class Detrepuestosor
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("ORDREP")]
        public int? Ordrep { get; set; }
        [Column("CANTID")]
        public int? Cantid { get; set; }
        [Column("ARTICU")]
        [StringLength(20)]
        public string Articu { get; set; }
        [Column("NOMART")]
        [StringLength(250)]
        public string Nomart { get; set; }
    }
}

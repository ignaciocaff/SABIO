using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("REPORTES")]
    public partial class Reportes
    {
        [Key]
        [Column("NUMINT")]
        public short Numint { get; set; }
        [Column("USUARI")]
        public short Usuari { get; set; }
        [Column("FECALT", TypeName = "DATE")]
        public DateTime? Fecalt { get; set; }
        [Column("DESCRI")]
        [StringLength(40)]
        public string Descri { get; set; }
        [Column("REPORT", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Report { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CURRENTPC")]
    public partial class Currentpc
    {
        [Column("MACADD")]
        [StringLength(20)]
        public string Macadd { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("NOMUSU")]
        [StringLength(40)]
        public string Nomusu { get; set; }
        [Column("FECIN", TypeName = "DATE")]
        public DateTime? Fecin { get; set; }
        [Column("HORIN", TypeName = "TIME")]
        public DateTime? Horin { get; set; }
        [Column("FECOUT", TypeName = "DATE")]
        public DateTime? Fecout { get; set; }
        [Column("HOROUT", TypeName = "TIME")]
        public DateTime? Horout { get; set; }
    }
}

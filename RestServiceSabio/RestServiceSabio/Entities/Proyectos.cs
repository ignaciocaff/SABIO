using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PROYECTOS")]
    public partial class Proyectos
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(60)]
        public string Nombre { get; set; }
        [Column("CUENTA")]
        public int? Cuenta { get; set; }
        [Column("ESTADO")]
        public short? Estado { get; set; }
        [Column("DESCRI", TypeName = "VARCHAR(10240)")]
        public string Descri { get; set; }
        [Column("FECING", TypeName = "DATE")]
        public DateTime? Fecing { get; set; }
        [Column("FECCOT", TypeName = "DATE")]
        public DateTime? Feccot { get; set; }
        [Column("FECINI", TypeName = "DATE")]
        public DateTime? Fecini { get; set; }
        [Column("FECFIN", TypeName = "DATE")]
        public DateTime? Fecfin { get; set; }
        [Column("CENCOS")]
        public short? Cencos { get; set; }
        [Column("OBSERV", TypeName = "VARCHAR(10240)")]
        public string Observ { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TIPOSLAYOUT")]
    public partial class Tiposlayout
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("TABLA")]
        [StringLength(20)]
        public string Tabla { get; set; }
        [Column("SENSQL", TypeName = "VARCHAR(10240)")]
        public string Sensql { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("MODELO", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Modelo { get; set; }
        [Column("MODEL2", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Model2 { get; set; }
        [Column("PRINCI")]
        public short? Princi { get; set; }
    }
}

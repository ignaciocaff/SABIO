using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PROFESIONALES")]
    public partial class Profesionales
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("CLAVE")]
        [StringLength(10)]
        public string Clave { get; set; }
        [Column("DOMICI")]
        [StringLength(40)]
        public string Domici { get; set; }
        [Column("TELEFO")]
        [StringLength(15)]
        public string Telefo { get; set; }
        [Column("BARRIO")]
        [StringLength(40)]
        public string Barrio { get; set; }
        [Column("DNI")]
        [StringLength(15)]
        public string Dni { get; set; }
        [Column("MATRIC")]
        [StringLength(15)]
        public string Matric { get; set; }
        [Column("LOCALI")]
        public int? Locali { get; set; }
    }
}

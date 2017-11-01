using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CHOFERES")]
    public partial class Choferes
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("DNI")]
        [StringLength(20)]
        public string Dni { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("DOMICI")]
        [StringLength(250)]
        public string Domici { get; set; }
        [Column("FECNAC", TypeName = "DATE")]
        public DateTime? Fecnac { get; set; }
        [Column("VEHDEF")]
        public short? Vehdef { get; set; }
        [Column("LEGAJO")]
        public short Legajo { get; set; }
        [Column("MAIL")]
        [StringLength(50)]
        public string Mail { get; set; }
    }
}

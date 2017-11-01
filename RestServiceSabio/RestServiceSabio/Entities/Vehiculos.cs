using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("VEHICULOS")]
    public partial class Vehiculos
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("PATCHA")]
        [StringLength(20)]
        public string Patcha { get; set; }
        [Required]
        [Column("PATALO")]
        [StringLength(20)]
        public string Patalo { get; set; }
        [Column("DESCRI")]
        [StringLength(200)]
        public string Descri { get; set; }
        [Column("CLIENT")]
        public int? Client { get; set; }
        [Column("ANO")]
        public short? Ano { get; set; }
        [Column("MODELO")]
        public int? Modelo { get; set; }
        [Column("MODACE")]
        public int Modace { get; set; }
        [Column("SEGURO")]
        [StringLength(40)]
        public string Seguro { get; set; }
        [Column("POLIZA")]
        [StringLength(40)]
        public string Poliza { get; set; }
        [Column("REMDEF")]
        public short? Remdef { get; set; }
        [Column("MOVIL")]
        public short Movil { get; set; }
    }
}

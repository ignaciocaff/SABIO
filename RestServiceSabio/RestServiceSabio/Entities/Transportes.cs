using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TRANSPORTES")]
    public partial class Transportes
    {
        [Key]
        [Column("CUENTA")]
        public int Cuenta { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("CUIT")]
        [StringLength(13)]
        public string Cuit { get; set; }
        [Column("DOMICI")]
        [StringLength(100)]
        public string Domici { get; set; }
        [Column("LOCALI")]
        [StringLength(60)]
        public string Locali { get; set; }
        [Column("TELEFO")]
        [StringLength(60)]
        public string Telefo { get; set; }
        [Column("SALIDA")]
        [StringLength(100)]
        public string Salida { get; set; }
        [Column("OBSERV")]
        [StringLength(1024)]
        public string Observ { get; set; }
    }
}

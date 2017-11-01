using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MARCA")]
    public partial class Marca
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("OBSERV")]
        [StringLength(250)]
        public string Observ { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MODELO")]
    public partial class Modelo
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("MARCA")]
        public int? Marca { get; set; }
        [Column("NOMBRE")]
        [StringLength(250)]
        public string Nombre { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("RUBROS_ART")]
    public partial class RubrosArt
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("MUEHIS")]
        public short? Muehis { get; set; }
        [Column("UNINEG")]
        public short? Unineg { get; set; }
    }
}

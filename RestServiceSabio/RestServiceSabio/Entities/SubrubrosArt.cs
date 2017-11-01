using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("SUBRUBROS_ART")]
    public partial class SubrubrosArt
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("RUBRO")]
        public short? Rubro { get; set; }
        [Column("COMPUT")]
        public short? Comput { get; set; }
        [Column("FORMUL")]
        [StringLength(250)]
        public string Formul { get; set; }
    }
}

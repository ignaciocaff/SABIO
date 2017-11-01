using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("GRUPO_ART")]
    public partial class GrupoArt
    {
        [Column("PADRE")]
        [StringLength(20)]
        public string Padre { get; set; }
        [Column("HIJO")]
        [StringLength(20)]
        public string Hijo { get; set; }
    }
}

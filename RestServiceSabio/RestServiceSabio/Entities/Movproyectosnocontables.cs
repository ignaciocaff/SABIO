using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOVPROYECTOSNOCONTABLES")]
    public partial class Movproyectosnocontables
    {
        [Column("PROYEC")]
        public int Proyec { get; set; }
        [Column("NOCONT")]
        public int Nocont { get; set; }
    }
}

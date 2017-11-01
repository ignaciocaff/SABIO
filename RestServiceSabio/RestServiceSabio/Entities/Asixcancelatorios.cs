using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ASIXCANCELATORIOS")]
    public partial class Asixcancelatorios
    {
        [Column("NUMCAN")]
        public int Numcan { get; set; }
        [Column("NUMASI")]
        public int Numasi { get; set; }
    }
}

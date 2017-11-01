using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("USUXGRU")]
    public partial class Usuxgru
    {
        [Column("USUARI")]
        public int Usuari { get; set; }
        [Column("GRUPO")]
        public int Grupo { get; set; }
    }
}

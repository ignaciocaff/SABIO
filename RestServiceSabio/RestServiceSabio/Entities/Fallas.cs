﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("FALLAS")]
    public partial class Fallas
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
    }
}

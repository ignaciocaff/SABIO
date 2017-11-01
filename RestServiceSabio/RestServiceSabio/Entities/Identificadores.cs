﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("IDENTIFICADORES")]
    public partial class Identificadores
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("VALIDA")]
        public short? Valida { get; set; }
        [Column("CODIVA")]
        public short? Codiva { get; set; }
    }
}

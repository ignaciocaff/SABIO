﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("VENCIMIENTOS_X_VTA")]
    public partial class VencimientosXVta
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("RUBRO")]
        public short Rubro { get; set; }
        [Column("SUBRUB")]
        public short Subrub { get; set; }
        [Column("MARCA")]
        public short Marca { get; set; }
        [Column("CLIENT")]
        public int Client { get; set; }
        [Column("DIAS")]
        public int? Dias { get; set; }
        [Column("PRIORI")]
        public short? Priori { get; set; }
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
        [Column("CATEGO")]
        public short? Catego { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("IMG_MOVCONTA")]
    public partial class ImgMovconta
    {
        [Column("CONTA")]
        public int Conta { get; set; }
        [Column("IMAGEN")]
        public int Imagen { get; set; }
    }
}

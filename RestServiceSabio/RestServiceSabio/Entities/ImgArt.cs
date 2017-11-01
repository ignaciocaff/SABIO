using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("IMG_ART")]
    public partial class ImgArt
    {
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
        [Column("IMAGEN")]
        public int Imagen { get; set; }
    }
}

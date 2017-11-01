using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("IMG_MOVNOCONTA")]
    public partial class ImgMovnoconta
    {
        [Column("NCONTA")]
        public int Nconta { get; set; }
        [Column("IMAGEN")]
        public int Imagen { get; set; }
    }
}

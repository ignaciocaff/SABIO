using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETPLANESXNOCON")]
    public partial class Detplanesxnocon
    {
        [Column("DETPLA")]
        public int Detpla { get; set; }
        [Column("DETNOC")]
        public int Detnoc { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MAXIMOS_X_DEPOSITOS")]
    public partial class MaximosXDepositos
    {
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
        [Column("DEPOSI")]
        public short Deposi { get; set; }
    }
}

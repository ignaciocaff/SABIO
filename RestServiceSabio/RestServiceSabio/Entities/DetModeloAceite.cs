using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DET_MODELO_ACEITE")]
    public partial class DetModeloAceite
    {
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("NUMMOD")]
        public int Nummod { get; set; }
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
        [Column("IDESUB")]
        public short Idesub { get; set; }
    }
}

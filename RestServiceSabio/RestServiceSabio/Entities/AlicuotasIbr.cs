using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ALICUOTAS_IBR")]
    public partial class AlicuotasIbr
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(60)]
        public string Nombre { get; set; }
    }
}

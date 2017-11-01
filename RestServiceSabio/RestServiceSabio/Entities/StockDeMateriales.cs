using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("STOCK_DE_MATERIALES")]
    public partial class StockDeMateriales
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("CODMAT")]
        [StringLength(10)]
        public string Codmat { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Column("OBSERV")]
        [StringLength(100)]
        public string Observ { get; set; }
        [Column("NUMASI")]
        public int Numasi { get; set; }
    }
}

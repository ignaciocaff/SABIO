using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ALERTAS")]
    public partial class Alertas
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("USUARI")]
        public short Usuari { get; set; }
        [Column("PROPIE")]
        public short Propie { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Column("PRIORI")]
        [StringLength(10)]
        public string Priori { get; set; }
        [Column("ASUNTO")]
        [StringLength(100)]
        public string Asunto { get; set; }
        [Column("DETALL")]
        [StringLength(1024)]
        public string Detall { get; set; }
        [Column("RESPUE")]
        [StringLength(1024)]
        public string Respue { get; set; }
        [Column("LEIDO")]
        public short? Leido { get; set; }
        [Column("VENCIM", TypeName = "DATE")]
        public DateTime? Vencim { get; set; }
        [Column("INICIO", TypeName = "DATE")]
        public DateTime? Inicio { get; set; }
        [Column("HORA", TypeName = "TIME")]
        public DateTime? Hora { get; set; }
    }
}

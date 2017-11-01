using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TRANSACCIONES")]
    public partial class Transacciones
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("NUMPLA")]
        public short? Numpla { get; set; }
        [Column("ACCION")]
        [StringLength(10)]
        public string Accion { get; set; }
        [Column("SUCURS")]
        public short? Sucurs { get; set; }
        [Column("PKNUME")]
        public int? Pknume { get; set; }
        [Column("ESTADO")]
        public short? Estado { get; set; }
        [Column("PKDEST")]
        public int? Pkdest { get; set; }
        [Column("EVENTO")]
        public int? Evento { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Column("HORA", TypeName = "TIME")]
        public DateTime? Hora { get; set; }
        [Column("OBSERV", TypeName = "VARCHAR(10240)")]
        public string Observ { get; set; }
    }
}

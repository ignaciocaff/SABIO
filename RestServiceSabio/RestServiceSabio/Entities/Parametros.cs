using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PARAMETROS")]
    public partial class Parametros
    {
        [Column("EMPRES")]
        public short Empres { get; set; }
        [Column("CODIGO")]
        [StringLength(10)]
        public string Codigo { get; set; }
        [Required]
        [Column("DESCRI")]
        [StringLength(40)]
        public string Descri { get; set; }
        [Column("FECHA1")]
        public DateTime? Fecha1 { get; set; }
        [Column("FECHA2")]
        public DateTime? Fecha2 { get; set; }
        [Column("BOOLE1")]
        public short? Boole1 { get; set; }
        [Column("BOOLE2")]
        public short? Boole2 { get; set; }
        [Column("TEXTO1")]
        [StringLength(500)]
        public string Texto1 { get; set; }
        [Column("TEXTO2")]
        [StringLength(500)]
        public string Texto2 { get; set; }
        [Column("MEMO1", TypeName = "VARCHAR(10240)")]
        public string Memo1 { get; set; }
        [Column("MEMO2", TypeName = "VARCHAR(10240)")]
        public string Memo2 { get; set; }
        [Column("CONFIG")]
        [StringLength(1024)]
        public string Config { get; set; }
    }
}

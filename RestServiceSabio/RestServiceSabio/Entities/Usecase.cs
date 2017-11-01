using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("USECASE")]
    public partial class Usecase
    {
        [Key]
        [Column("CODIGO")]
        [StringLength(10)]
        public string Codigo { get; set; }
        [Required]
        [Column("DESCRI")]
        [StringLength(40)]
        public string Descri { get; set; }
        [Column("BLOQUE")]
        public short? Bloque { get; set; }
        [Required]
        [Column("RAMA")]
        [StringLength(20)]
        public string Rama { get; set; }
        [Column("LABEL")]
        [StringLength(40)]
        public string Label { get; set; }
        [Column("ESNODO")]
        public short? Esnodo { get; set; }
        [Required]
        [Column("NODO")]
        [StringLength(10)]
        public string Nodo { get; set; }
        [Column("FORMUL")]
        [StringLength(40)]
        public string Formul { get; set; }
        [Column("PARAME")]
        [StringLength(250)]
        public string Parame { get; set; }
        [Column("IMAGE1")]
        [StringLength(40)]
        public string Image1 { get; set; }
        [Column("IMAGE2")]
        [StringLength(40)]
        public string Image2 { get; set; }
        [Column("OCULTA")]
        public short? Oculta { get; set; }
        [Column("WEBMNU")]
        [StringLength(40)]
        public string Webmnu { get; set; }
        [Column("WEBURL")]
        [StringLength(100)]
        public string Weburl { get; set; }
        [Column("CONFIG", TypeName = "VARCHAR(10240)")]
        public string Config { get; set; }
    }
}

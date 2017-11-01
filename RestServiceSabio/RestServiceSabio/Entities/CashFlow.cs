using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CASH_FLOW")]
    public partial class CashFlow
    {
        [Key]
        [Column("CODIGO")]
        [StringLength(10)]
        public string Codigo { get; set; }
        [Column("ORDEN")]
        public short Orden { get; set; }
        [Required]
        [Column("DESCRI")]
        [StringLength(100)]
        public string Descri { get; set; }
        [Column("TITULO")]
        public short? Titulo { get; set; }
        [Column("COLOR")]
        [StringLength(20)]
        public string Color { get; set; }
        [Column("SQLLIS")]
        [StringLength(4096)]
        public string Sqllis { get; set; }
        [Column("SQLVEN")]
        [StringLength(4096)]
        public string Sqlven { get; set; }
        [Column("TIPCAS")]
        public short Tipcas { get; set; }
        [Column("FORMUL")]
        public short? Formul { get; set; }
        [Column("CAMTOT")]
        [StringLength(10)]
        public string Camtot { get; set; }
        [Column("SQLDIA")]
        [StringLength(4096)]
        public string Sqldia { get; set; }
        [Column("ACUTOT")]
        public short? Acutot { get; set; }
        [Column("LISDIA")]
        [StringLength(4096)]
        public string Lisdia { get; set; }
        [Column("BOLD")]
        public short? Bold { get; set; }
        [Column("TAMANO")]
        public short? Tamano { get; set; }
        [Column("LETRA")]
        [StringLength(20)]
        public string Letra { get; set; }
    }
}

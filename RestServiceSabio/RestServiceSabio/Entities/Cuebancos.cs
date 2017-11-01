using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CUEBANCOS")]
    public partial class Cuebancos
    {
        public Cuebancos()
        {
            Movbancos = new HashSet<Movbancos>();
        }

        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("CTABAN")]
        [StringLength(40)]
        public string Ctaban { get; set; }
        [Column("TIPO")]
        public short Tipo { get; set; }
        [Column("MONEDA")]
        public short Moneda { get; set; }
        [Column("BANCO")]
        public short Banco { get; set; }
        [Column("SUCURS")]
        public short? Sucurs { get; set; }
        [Column("SUCNOM")]
        [StringLength(40)]
        public string Sucnom { get; set; }
        [Column("DOMICI")]
        [StringLength(40)]
        public string Domici { get; set; }
        [Column("TELEFO")]
        [StringLength(40)]
        public string Telefo { get; set; }
        [Column("FAX")]
        [StringLength(40)]
        public string Fax { get; set; }
        [Column("CONTAC")]
        [StringLength(40)]
        public string Contac { get; set; }
        [Column("MAIL")]
        [StringLength(50)]
        public string Mail { get; set; }
        [Required]
        [Column("CUENTA")]
        [StringLength(12)]
        public string Cuenta { get; set; }
        [Column("TRANDE")]
        public short? Trande { get; set; }
        [Column("TRANID")]
        public int? Tranid { get; set; }
        [Column("DESHAB")]
        public short? Deshab { get; set; }

        [ForeignKey("Cuenta")]
        [InverseProperty("Cuebancos")]
        public Plancuentas CuentaNavigation { get; set; }
        [InverseProperty("NumeroNavigation")]
        public ICollection<Movbancos> Movbancos { get; set; }
    }
}

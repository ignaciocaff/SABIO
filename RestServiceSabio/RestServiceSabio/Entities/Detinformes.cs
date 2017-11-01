using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETINFORMES")]
    public partial class Detinformes
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("CODIGO")]
        [StringLength(10)]
        public string Codigo { get; set; }
        [Required]
        [Column("DESCRI")]
        [StringLength(60)]
        public string Descri { get; set; }
        [Required]
        [Column("CUENTA")]
        [StringLength(12)]
        public string Cuenta { get; set; }
        [Required]
        [Column("GRUPO")]
        [StringLength(10)]
        public string Grupo { get; set; }
        [Required]
        [Column("FORMUL")]
        [StringLength(250)]
        public string Formul { get; set; }
        [Column("PORCEN")]
        [StringLength(10)]
        public string Porcen { get; set; }
        [Column("GRAFIC")]
        public short? Grafic { get; set; }
        [Column("SUBTOT")]
        public short? Subtot { get; set; }
        [Column("COLOR")]
        public int? Color { get; set; }
        [Column("UNIDAD")]
        public short Unidad { get; set; }
        [Column("VISIBLE")]
        public short? Visible { get; set; }

        [ForeignKey("Cuenta")]
        [InverseProperty("Detinformes")]
        public Plancuentas CuentaNavigation { get; set; }
    }
}

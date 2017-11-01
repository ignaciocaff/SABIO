using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("EMPRESAS")]
    public partial class Empresas
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("DENOMI")]
        [StringLength(40)]
        public string Denomi { get; set; }
        [Column("DOMICI")]
        [StringLength(40)]
        public string Domici { get; set; }
        [Column("BARRIO")]
        [StringLength(40)]
        public string Barrio { get; set; }
        [Column("LOCALI")]
        public int Locali { get; set; }
        [Column("CODPOS")]
        [StringLength(10)]
        public string Codpos { get; set; }
        [Column("TELEFO")]
        [StringLength(40)]
        public string Telefo { get; set; }
        [Column("FAX")]
        [StringLength(40)]
        public string Fax { get; set; }
        [Column("MAIL")]
        [StringLength(40)]
        public string Mail { get; set; }
        [Column("WWW")]
        [StringLength(40)]
        public string Www { get; set; }
        [Column("REPRES")]
        [StringLength(40)]
        public string Repres { get; set; }
        [Column("IDENTI")]
        public short Identi { get; set; }
        [Column("CUIT")]
        [StringLength(13)]
        public string Cuit { get; set; }
        [Column("REGIVA")]
        public short Regiva { get; set; }
        [Column("REGIBR")]
        public short Regibr { get; set; }
        [Column("REGGAN")]
        public short Reggan { get; set; }
        [Column("CONGAN")]
        public short Congan { get; set; }
        [Column("INGBRU")]
        [StringLength(20)]
        public string Ingbru { get; set; }
        [Column("MUNICI")]
        [StringLength(20)]
        public string Munici { get; set; }
        [Column("FECALT")]
        public DateTime? Fecalt { get; set; }
        [Column("OBSERV")]
        [StringLength(50)]
        public string Observ { get; set; }
        [Column("HABILI")]
        public short? Habili { get; set; }
        [Column("CAUSA")]
        [StringLength(50)]
        public string Causa { get; set; }
    }
}

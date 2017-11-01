using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CUENTAS")]
    public partial class Cuentas
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("TIPO")]
        public short Tipo { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
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
        [Column("MOVIL")]
        [StringLength(40)]
        public string Movil { get; set; }
        [Column("MAIL")]
        [StringLength(40)]
        public string Mail { get; set; }
        [Column("WWW")]
        [StringLength(40)]
        public string Www { get; set; }
        [Column("ZONA")]
        public short Zona { get; set; }
        [Column("REPRES")]
        [StringLength(40)]
        public string Repres { get; set; }
        [Column("ACTIVI")]
        public short Activi { get; set; }
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
        [Column("INGBRU")]
        [StringLength(20)]
        public string Ingbru { get; set; }
        [Column("FECALT")]
        public DateTime? Fecalt { get; set; }
        [Column("OBSERV")]
        [StringLength(1024)]
        public string Observ { get; set; }
        [Column("CATEGO")]
        public short Catego { get; set; }
        [Column("HABILI")]
        public short? Habili { get; set; }
        [Column("CAUSA")]
        [StringLength(50)]
        public string Causa { get; set; }
        [Column("TRANSP")]
        [StringLength(40)]
        public string Transp { get; set; }
        [Column("NROPRO")]
        public int? Nropro { get; set; }
        [Column("CONGAN")]
        public short Congan { get; set; }
        [Column("BANCO")]
        [StringLength(40)]
        public string Banco { get; set; }
        [Column("CBU")]
        [StringLength(25)]
        public string Cbu { get; set; }
        [Column("RESPON")]
        [StringLength(40)]
        public string Respon { get; set; }
        [Column("PATH")]
        [StringLength(200)]
        public string Path { get; set; }
        [Column("FECNAC", TypeName = "DATE")]
        public DateTime? Fecnac { get; set; }
        [Column("VENDED")]
        public short Vended { get; set; }
        [Required]
        [Column("CUENTA", TypeName = "CHAR(12) CHARACTER SET NONE")]
        public string Cuenta { get; set; }
        [Column("NROCAI")]
        [StringLength(20)]
        public string Nrocai { get; set; }
        [Column("FECCAI", TypeName = "DATE")]
        public DateTime? Feccai { get; set; }
        [Column("ALIIBR")]
        public int? Aliibr { get; set; }
        [Column("TEXTO1")]
        [StringLength(100)]
        public string Texto1 { get; set; }
        [Column("TEXTO2")]
        [StringLength(100)]
        public string Texto2 { get; set; }
        [Column("NUMER1")]
        public int? Numer1 { get; set; }
        [Column("NUMER2")]
        public int? Numer2 { get; set; }
        [Column("FECHA1", TypeName = "DATE")]
        public DateTime? Fecha1 { get; set; }
        [Column("FECHA2", TypeName = "DATE")]
        public DateTime? Fecha2 { get; set; }
        [Column("BOOLE1")]
        public short? Boole1 { get; set; }
        [Column("BOOLE2")]
        public short? Boole2 { get; set; }
        [Column("MONEDA")]
        public short Moneda { get; set; }

        [ForeignKey("Cuenta")]
        [InverseProperty("Cuentas")]
        public Plancuentas CuentaNavigation { get; set; }
    }
}

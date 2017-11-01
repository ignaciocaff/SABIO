using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PLANCUENTAS")]
    public partial class Plancuentas
    {
        public Plancuentas()
        {
            Autoasiento = new HashSet<Autoasiento>();
            Codbancos = new HashSet<Codbancos>();
            Cuebancos = new HashSet<Cuebancos>();
            Cuentas = new HashSet<Cuentas>();
            Detasientos = new HashSet<Detasientos>();
            Detasientosmodelos = new HashSet<Detasientosmodelos>();
            Detinformes = new HashSet<Detinformes>();
            Detprorrateos = new HashSet<Detprorrateos>();
            PresupCtas = new HashSet<PresupCtas>();
            Tipocuenta = new HashSet<Tipocuenta>();
        }

        [Key]
        [Column("CUENTA")]
        [StringLength(12)]
        public string Cuenta { get; set; }
        [Required]
        [Column("DESCRI")]
        [StringLength(40)]
        public string Descri { get; set; }
        [Column("HABILI")]
        public short? Habili { get; set; }
        [Column("CUECAJ")]
        public short? Cuecaj { get; set; }
        [Column("GENCTA")]
        public short? Gencta { get; set; }
        [Column("PRORRA")]
        public short? Prorra { get; set; }
        [Column("UNINEG")]
        public short? Unineg { get; set; }
        [Column("RESUMI")]
        public short? Resumi { get; set; }
        [Column("CUEDES")]
        public short? Cuedes { get; set; }
        [Column("TIPCUE")]
        public short? Tipcue { get; set; }
        [Column("PRESUP")]
        public short? Presup { get; set; }
        [Column("MONEDA")]
        public short? Moneda { get; set; }
        [Column("PERCEP")]
        public short? Percep { get; set; }

        [InverseProperty("CuentaNavigation")]
        public ICollection<Autoasiento> Autoasiento { get; set; }
        [InverseProperty("CuentaNavigation")]
        public ICollection<Codbancos> Codbancos { get; set; }
        [InverseProperty("CuentaNavigation")]
        public ICollection<Cuebancos> Cuebancos { get; set; }
        [InverseProperty("CuentaNavigation")]
        public ICollection<Cuentas> Cuentas { get; set; }
        [InverseProperty("CuentaNavigation")]
        public ICollection<Detasientos> Detasientos { get; set; }
        [InverseProperty("CuentaNavigation")]
        public ICollection<Detasientosmodelos> Detasientosmodelos { get; set; }
        [InverseProperty("CuentaNavigation")]
        public ICollection<Detinformes> Detinformes { get; set; }
        [InverseProperty("CuentaNavigation")]
        public ICollection<Detprorrateos> Detprorrateos { get; set; }
        [InverseProperty("CuentaNavigation")]
        public ICollection<PresupCtas> PresupCtas { get; set; }
        [InverseProperty("CuentaNavigation")]
        public ICollection<Tipocuenta> Tipocuenta { get; set; }
    }
}

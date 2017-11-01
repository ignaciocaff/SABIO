using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOVCONTABLES")]
    public partial class Movcontables
    {
        public Movcontables()
        {
            Detmovcontables = new HashSet<Detmovcontables>();
            Detpagoscuotas = new HashSet<Detpagoscuotas>();
            Detretenciones = new HashSet<Detretenciones>();
            MovManodeobra = new HashSet<MovManodeobra>();
            Movproyectoscontables = new HashSet<Movproyectoscontables>();
            Movventas = new HashSet<Movventas>();
            PickingConta = new HashSet<PickingConta>();
            Plancuotas = new HashSet<Plancuotas>();
        }

        [Key]
        [Column("ASIENT")]
        public int Asient { get; set; }
        [Column("UNINEG")]
        public short Unineg { get; set; }
        [Column("FECHA")]
        public DateTime Fecha { get; set; }
        [Required]
        [Column("COMPRO")]
        [StringLength(3)]
        public string Compro { get; set; }
        [Required]
        [Column("NROCOM")]
        [StringLength(13)]
        public string Nrocom { get; set; }
        [Column("CTACTE")]
        public int Ctacte { get; set; }
        [Column("FORPAG")]
        public short Forpag { get; set; }
        [Column("FECVEN")]
        public DateTime? Fecven { get; set; }
        [Column("NROCBU")]
        [StringLength(15)]
        public string Nrocbu { get; set; }
        [Column("FECCBU", TypeName = "DATE")]
        public DateTime? Feccbu { get; set; }
        [Column("CONTRA")]
        public int? Contra { get; set; }
        [Column("FECCAN")]
        public DateTime? Feccan { get; set; }
        [Column("FECANU")]
        public DateTime? Fecanu { get; set; }
        [Column("NUMTIT")]
        public int Numtit { get; set; }
        [Column("TITULA")]
        [StringLength(40)]
        public string Titula { get; set; }
        [Column("CUIT")]
        [StringLength(13)]
        public string Cuit { get; set; }
        [Column("MONEDA")]
        public short Moneda { get; set; }
        [Column("OBSERV", TypeName = "VARCHAR(10240)")]
        public string Observ { get; set; }
        [Column("STRDES")]
        [StringLength(20)]
        public string Strdes { get; set; }
        [Column("LISPRE")]
        public short? Lispre { get; set; }
        [Column("NROCAI")]
        [StringLength(20)]
        public string Nrocai { get; set; }
        [Column("FECCAI", TypeName = "DATE")]
        public DateTime? Feccai { get; set; }
        [Column("IMPFIS")]
        public short? Impfis { get; set; }
        [Column("NROCAE")]
        [StringLength(512)]
        public string Nrocae { get; set; }
        [Column("FECCAE", TypeName = "DATE")]
        public DateTime? Feccae { get; set; }
        [Column("CAE_ID")]
        public int? CaeId { get; set; }
        [Column("TEXTO1")]
        [StringLength(250)]
        public string Texto1 { get; set; }
        [Column("TEXTO2")]
        [StringLength(250)]
        public string Texto2 { get; set; }

        [InverseProperty("AsientNavigation")]
        public ICollection<Detmovcontables> Detmovcontables { get; set; }
        [InverseProperty("AsientNavigation")]
        public ICollection<Detpagoscuotas> Detpagoscuotas { get; set; }
        [InverseProperty("AsientNavigation")]
        public ICollection<Detretenciones> Detretenciones { get; set; }
        [InverseProperty("AsientNavigation")]
        public ICollection<MovManodeobra> MovManodeobra { get; set; }
        [InverseProperty("AsientNavigation")]
        public ICollection<Movproyectoscontables> Movproyectoscontables { get; set; }
        [InverseProperty("AsientNavigation")]
        public ICollection<Movventas> Movventas { get; set; }
        [InverseProperty("AsientNavigation")]
        public ICollection<PickingConta> PickingConta { get; set; }
        [InverseProperty("AsientNavigation")]
        public ICollection<Plancuotas> Plancuotas { get; set; }
    }
}

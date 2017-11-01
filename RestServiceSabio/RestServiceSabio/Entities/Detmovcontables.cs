using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETMOVCONTABLES")]
    public partial class Detmovcontables
    {
        public Detmovcontables()
        {
            DetLiquidaciones = new HashSet<DetLiquidaciones>();
            DetLiquidacionesXMonto = new HashSet<DetLiquidacionesXMonto>();
            Detconxnoconxart = new HashSet<Detconxnoconxart>();
            Movserialescontables = new HashSet<Movserialescontables>();
            NegoContables = new HashSet<NegoContables>();
        }

        [Column("ASIENT")]
        public int Asient { get; set; }
        [Column("REGLON")]
        public short Reglon { get; set; }
        [Required]
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
        [Column("DESCRI")]
        [StringLength(250)]
        public string Descri { get; set; }
        [Column("CTRASI")]
        public int? Ctrasi { get; set; }
        [Column("CTRREG")]
        public short? Ctrreg { get; set; }
        [Column("STRDES")]
        [StringLength(20)]
        public string Strdes { get; set; }
        [Column("GTACOM")]
        public short? Gtacom { get; set; }
        [Column("GTAVTA")]
        public short? Gtavta { get; set; }
        [Column("NRODES")]
        [StringLength(100)]
        public string Nrodes { get; set; }
        [Column("NOIMPR")]
        public short? Noimpr { get; set; }
        [Column("LIQPRO")]
        public int? Liqpro { get; set; }
        [Column("LISPRE")]
        public short Lispre { get; set; }

        [ForeignKey("Asient")]
        [InverseProperty("Detmovcontables")]
        public Movcontables AsientNavigation { get; set; }
        [InverseProperty("Detmovcontables")]
        public ICollection<DetLiquidaciones> DetLiquidaciones { get; set; }
        [InverseProperty("Detmovcontables")]
        public ICollection<DetLiquidacionesXMonto> DetLiquidacionesXMonto { get; set; }
        [InverseProperty("Detmovcontables")]
        public ICollection<Detconxnoconxart> Detconxnoconxart { get; set; }
        [InverseProperty("Detmovcontables")]
        public ICollection<Movserialescontables> Movserialescontables { get; set; }
        [InverseProperty("Detmovcontables")]
        public ICollection<NegoContables> NegoContables { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETMOVNOCONART")]
    public partial class Detmovnoconart
    {
        public Detmovnoconart()
        {
            Detconxnoconxart = new HashSet<Detconxnoconxart>();
        }

        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("CANTID")]
        public double Cantid { get; set; }
        [Column("ORDEN")]
        public short? Orden { get; set; }
        [Column("CODART")]
        [StringLength(20)]
        public string Codart { get; set; }
        [Column("DESCRI")]
        [StringLength(250)]
        public string Descri { get; set; }
        [Column("FECENT", TypeName = "DATE")]
        public DateTime? Fecent { get; set; }
        [Column("CTRCOM")]
        public int Ctrcom { get; set; }
        [Column("CENCOS")]
        public short Cencos { get; set; }
        [Column("STRDES")]
        [StringLength(20)]
        public string Strdes { get; set; }
        [Column("ESHIJO")]
        public short? Eshijo { get; set; }
        [Column("GTACOM")]
        public short? Gtacom { get; set; }
        [Column("GTAVTA")]
        public short? Gtavta { get; set; }
        [Column("NRODES")]
        [StringLength(100)]
        public string Nrodes { get; set; }
        [Column("TRANID")]
        public int? Tranid { get; set; }
        [Column("PRIORI")]
        public short? Priori { get; set; }
        [Column("LISPRE")]
        public short Lispre { get; set; }
        [Column("PRESEN")]
        public double Presen { get; set; }

        [InverseProperty("NumintNavigation")]
        public ICollection<Detconxnoconxart> Detconxnoconxart { get; set; }
    }
}

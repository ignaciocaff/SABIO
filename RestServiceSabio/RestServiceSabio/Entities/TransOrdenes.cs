using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TRANS_ORDENES")]
    public partial class TransOrdenes
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Column("ESTADO")]
        public short? Estado { get; set; }
        [Column("INCOTE")]
        public short? Incote { get; set; }
        [Column("REMITE")]
        public int? Remite { get; set; }
        [Column("ORIGEN")]
        public short? Origen { get; set; }
        [Column("FECCAR", TypeName = "DATE")]
        public DateTime? Feccar { get; set; }
        [Column("HORCAR", TypeName = "TIME")]
        public DateTime? Horcar { get; set; }
        [Column("NUMPED")]
        [StringLength(20)]
        public string Numped { get; set; }
        [Column("NUMREF")]
        [StringLength(20)]
        public string Numref { get; set; }
        [Column("CONSIG")]
        public int? Consig { get; set; }
        [Column("DESTIN")]
        public short? Destin { get; set; }
        [Column("FECENT", TypeName = "DATE")]
        public DateTime? Fecent { get; set; }
        [Column("HORENT", TypeName = "TIME")]
        public DateTime? Horent { get; set; }
        [Column("CONTAC")]
        [StringLength(40)]
        public string Contac { get; set; }
        [Column("OBSENT")]
        [StringLength(60)]
        public string Obsent { get; set; }
        [Column("PRODUC")]
        [StringLength(20)]
        public string Produc { get; set; }
        [Column("OBSPRO")]
        [StringLength(60)]
        public string Obspro { get; set; }
        [Column("NUMCHO")]
        public short? Numcho { get; set; }
        [Column("NUMVEH")]
        public short? Numveh { get; set; }
        [Column("NUMREM")]
        public short? Numrem { get; set; }
        [Column("OBSOPE")]
        [StringLength(60)]
        public string Obsope { get; set; }
        [Column("CARTAP")]
        [StringLength(20)]
        public string Cartap { get; set; }
        [Column("NOCONTA")]
        public int? Noconta { get; set; }
        [Column("ID_CAR")]
        public int? IdCar { get; set; }
        [Column("NUMEMP")]
        public short Numemp { get; set; }
    }
}

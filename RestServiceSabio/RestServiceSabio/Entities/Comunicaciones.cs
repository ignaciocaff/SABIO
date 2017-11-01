using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("COMUNICACIONES")]
    public partial class Comunicaciones
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("ORIGEN")]
        public short Origen { get; set; }
        [Column("TEMA")]
        public short Tema { get; set; }
        [Column("SECTOR")]
        public short Sector { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Column("HORA", TypeName = "TIME")]
        public DateTime? Hora { get; set; }
        [Column("PARA")]
        public short Para { get; set; }
        [Column("DE")]
        [StringLength(40)]
        public string De { get; set; }
        [Column("EMPRES")]
        public short Empres { get; set; }
        [Column("MENSAG", TypeName = "VARCHAR(10240)")]
        public string Mensag { get; set; }
        [Column("CONTAC")]
        [StringLength(60)]
        public string Contac { get; set; }
        [Column("TIPMSG")]
        public short Tipmsg { get; set; }
        [Column("LEIDO")]
        public short? Leido { get; set; }
        [Column("FECLEI", TypeName = "DATE")]
        public DateTime? Feclei { get; set; }
        [Column("HORLEI", TypeName = "TIME")]
        public DateTime? Horlei { get; set; }
    }
}

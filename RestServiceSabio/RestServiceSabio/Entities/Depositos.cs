using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DEPOSITOS")]
    public partial class Depositos
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("DIRECC")]
        [StringLength(40)]
        public string Direcc { get; set; }
        [Column("TELEFO")]
        [StringLength(40)]
        public string Telefo { get; set; }
        [Column("BOCA", TypeName = "CHAR(4) CHARACTER SET NONE")]
        public string Boca { get; set; }
        [Column("BOCFAC", TypeName = "CHAR(4) CHARACTER SET NONE")]
        public string Bocfac { get; set; }
        [Column("CASCEN")]
        public short? Cascen { get; set; }
        [Column("LOCVEN")]
        public short? Locven { get; set; }
        [Column("FABRIC")]
        public short? Fabric { get; set; }
        [Column("ADMINI")]
        public short? Admini { get; set; }
        [Column("MONEDA")]
        public short? Moneda { get; set; }
        [Column("CENCOS")]
        public short? Cencos { get; set; }
        [Column("NUMSUC")]
        public short Numsuc { get; set; }
    }
}

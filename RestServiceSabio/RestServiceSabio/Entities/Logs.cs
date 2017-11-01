using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("LOGS")]
    public partial class Logs
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("CASOUS")]
        [StringLength(10)]
        public string Casous { get; set; }
        [Column("FECHA")]
        public DateTime Fecha { get; set; }
        [Column("HORA")]
        [StringLength(16)]
        public string Hora { get; set; }
        [Column("USUARI")]
        public short Usuari { get; set; }
        [Column("PKNUME")]
        public int? Pknume { get; set; }
        [Column("PKTEXT")]
        [StringLength(20)]
        public string Pktext { get; set; }
        [Column("OBSERV", TypeName = "VARCHAR(10000)")]
        public string Observ { get; set; }
        [Column("WINUSE")]
        [StringLength(20)]
        public string Winuse { get; set; }
        [Column("WINNET")]
        [StringLength(20)]
        public string Winnet { get; set; }
    }
}

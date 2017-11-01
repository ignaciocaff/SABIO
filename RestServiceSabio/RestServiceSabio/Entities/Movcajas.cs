using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("MOVCAJAS")]
    public partial class Movcajas
    {
        public Movcajas()
        {
            Asixcaja = new HashSet<Asixcaja>();
        }

        [Key]
        [Column("NROMOV")]
        public int Nromov { get; set; }
        [Column("NROCAJ")]
        public short Nrocaj { get; set; }
        [Column("USUARI")]
        public short Usuari { get; set; }
        [Column("FECAPE", TypeName = "DATE")]
        public DateTime Fecape { get; set; }
        [Column("FECCIE", TypeName = "DATE")]
        public DateTime? Feccie { get; set; }
        [Column("HORAPE", TypeName = "TIME")]
        public DateTime? Horape { get; set; }
        [Column("HORCIE", TypeName = "TIME")]
        public DateTime? Horcie { get; set; }

        [InverseProperty("NromovNavigation")]
        public ICollection<Asixcaja> Asixcaja { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CHEQUESPRO")]
    public partial class Chequespro
    {
        public Chequespro()
        {
            Movchequespro = new HashSet<Movchequespro>();
        }

        [Column("CHEQUE")]
        public short Cheque { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("FECHA")]
        public DateTime Fecha { get; set; }
        [Column("FECVEN")]
        public DateTime Fecven { get; set; }
        [Column("TITULA")]
        [StringLength(50)]
        public string Titula { get; set; }
        [Column("NOALAO")]
        public short? Noalao { get; set; }

        [InverseProperty("Chequespro")]
        public ICollection<Movchequespro> Movchequespro { get; set; }
    }
}

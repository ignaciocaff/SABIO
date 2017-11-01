using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CHEQUES3")]
    public partial class Cheques3
    {
        public Cheques3()
        {
            Movcheques3 = new HashSet<Movcheques3>();
        }

        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("BANCO")]
        public short Banco { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("FECHA")]
        public DateTime Fecha { get; set; }
        [Column("FECVEN")]
        public DateTime Fecven { get; set; }
        [Column("MONEDA")]
        public short Moneda { get; set; }
        [Column("TITULA")]
        [StringLength(50)]
        public string Titula { get; set; }
        [Column("NOALAO")]
        public short? Noalao { get; set; }
        [Column("TERCER")]
        public short? Tercer { get; set; }
        [Column("TRANDE")]
        public short? Trande { get; set; }
        [Column("TRANID")]
        public int? Tranid { get; set; }
        [Column("DOCUME")]
        public short? Docume { get; set; }

        [InverseProperty("NumintNavigation")]
        public ICollection<Movcheques3> Movcheques3 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CANCELATORIOS")]
    public partial class Cancelatorios
    {
        public Cancelatorios()
        {
            Detcancelatorios = new HashSet<Detcancelatorios>();
        }

        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
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
        [Column("NUMTIT")]
        public int Numtit { get; set; }
        [Column("TITULA")]
        [StringLength(40)]
        public string Titula { get; set; }
        [Column("CUIT")]
        [StringLength(13)]
        public string Cuit { get; set; }
        [Column("OBSERV", TypeName = "VARCHAR(10240)")]
        public string Observ { get; set; }

        [InverseProperty("NumintNavigation")]
        public ICollection<Detcancelatorios> Detcancelatorios { get; set; }
    }
}

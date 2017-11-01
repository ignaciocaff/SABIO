using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ASIENTOS")]
    public partial class Asientos
    {
        public Asientos()
        {
            Detasientos = new HashSet<Detasientos>();
        }

        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("FECHA")]
        public DateTime Fecha { get; set; }
        [Required]
        [Column("CONCEP")]
        [StringLength(250)]
        public string Concep { get; set; }
        [Column("TIPO")]
        public short? Tipo { get; set; }
        [Column("OCULTA")]
        public short? Oculta { get; set; }
        [Column("DEPOSI")]
        public short? Deposi { get; set; }
        [Column("ASIDEP")]
        public short? Asidep { get; set; }
        [Column("ASINUM")]
        public int? Asinum { get; set; }
        [Column("RESPON")]
        public short Respon { get; set; }
        [Column("UNINEG")]
        public short? Unineg { get; set; }
        [Column("FECING", TypeName = "DATE")]
        public DateTime? Fecing { get; set; }
        [Column("PRESUP")]
        public short? Presup { get; set; }
        [Column("SUBTIP")]
        public short? Subtip { get; set; }
        [Column("HORA", TypeName = "TIME")]
        public DateTime? Hora { get; set; }

        [InverseProperty("NumeroNavigation")]
        public ICollection<Detasientos> Detasientos { get; set; }
    }
}

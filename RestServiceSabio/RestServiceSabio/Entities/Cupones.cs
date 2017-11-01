using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CUPONES")]
    public partial class Cupones
    {
        public Cupones()
        {
            Movcupones = new HashSet<Movcupones>();
        }

        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Required]
        [Column("NUMTAR")]
        [StringLength(50)]
        public string Numtar { get; set; }
        [Column("TARJET")]
        public short Tarjet { get; set; }
        [Column("AUTORI")]
        [StringLength(50)]
        public string Autori { get; set; }
        [Column("TIPO")]
        public short Tipo { get; set; }
        [Column("TITULA")]
        [StringLength(40)]
        public string Titula { get; set; }
        [Column("TELEFO")]
        [StringLength(40)]
        public string Telefo { get; set; }
        [Column("TRANDE")]
        public short? Trande { get; set; }
        [Column("TRANID")]
        public int? Tranid { get; set; }

        [InverseProperty("NumintNavigation")]
        public ICollection<Movcupones> Movcupones { get; set; }
    }
}

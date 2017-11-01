using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ARBOL")]
    public partial class Arbol
    {
        [Key]
        [Column("CODIGO")]
        [StringLength(20)]
        public string Codigo { get; set; }
        [Required]
        [Column("LABEL")]
        [StringLength(40)]
        public string Label { get; set; }
        [Required]
        [Column("PADRE")]
        [StringLength(20)]
        public string Padre { get; set; }
        [Column("IMAGE1")]
        [StringLength(40)]
        public string Image1 { get; set; }
        [Column("IMAGE2")]
        [StringLength(40)]
        public string Image2 { get; set; }
        [Column("ORDEN")]
        public short? Orden { get; set; }
        [Column("OCULTA")]
        public short? Oculta { get; set; }
        [Column("EDICIO")]
        [StringLength(20)]
        public string Edicio { get; set; }
    }
}

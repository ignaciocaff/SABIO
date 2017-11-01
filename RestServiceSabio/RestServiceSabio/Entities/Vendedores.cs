using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("VENDEDORES")]
    public partial class Vendedores
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("DESHAB")]
        public short? Deshab { get; set; }
        [Column("FORMU1")]
        [StringLength(100)]
        public string Formu1 { get; set; }
        [Column("FORMU2")]
        [StringLength(100)]
        public string Formu2 { get; set; }
        [Column("USUARI")]
        public short? Usuari { get; set; }
        [Column("CATEGO")]
        [StringLength(40)]
        public string Catego { get; set; }
        [Column("FECING", TypeName = "DATE")]
        public DateTime? Fecing { get; set; }
        [Column("TAREA")]
        [StringLength(40)]
        public string Tarea { get; set; }
        [Column("PRODUC")]
        [StringLength(100)]
        public string Produc { get; set; }
        [Column("ZONA")]
        [StringLength(40)]
        public string Zona { get; set; }
    }
}

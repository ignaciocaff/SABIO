using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("PROYECTOSOBRAS")]
    public partial class Proyectosobras
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("FECALT", TypeName = "DATE")]
        public DateTime? Fecalt { get; set; }
        [Column("DESCRI")]
        [StringLength(200)]
        public string Descri { get; set; }
        [Column("CUENTA")]
        public int Cuenta { get; set; }
        [Column("CATAST")]
        [StringLength(40)]
        public string Catast { get; set; }
        [Column("ESTADO")]
        public short Estado { get; set; }
        [Column("TIPO")]
        public short Tipo { get; set; }
        [Column("PATH")]
        [StringLength(50)]
        public string Path { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("CENCOS")]
        public short? Cencos { get; set; }
    }
}

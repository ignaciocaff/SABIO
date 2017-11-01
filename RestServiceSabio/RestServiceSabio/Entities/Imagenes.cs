using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("IMAGENES")]
    public partial class Imagenes
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("TIPO")]
        public short Tipo { get; set; }
        [Column("NOMBRE")]
        [StringLength(60)]
        public string Nombre { get; set; }
        [Column("PATORI")]
        [StringLength(250)]
        public string Patori { get; set; }
        [Column("IMAGEN", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Imagen { get; set; }
    }
}

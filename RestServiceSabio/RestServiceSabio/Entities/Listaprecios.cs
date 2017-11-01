using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("LISTAPRECIOS")]
    public partial class Listaprecios
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("DESCRI")]
        [StringLength(40)]
        public string Descri { get; set; }
        [Column("CATEGO")]
        public short? Catego { get; set; }
        [Column("DIAVEN")]
        public int? Diaven { get; set; }
        [Column("FACSUB")]
        public short? Facsub { get; set; }
        [Column("VALDES", TypeName = "DATE")]
        public DateTime? Valdes { get; set; }
        [Column("VALHAS", TypeName = "DATE")]
        public DateTime? Valhas { get; set; }
    }
}

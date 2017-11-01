using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("EQUIXMODELO")]
    public partial class Equixmodelo
    {
        [Column("GRUPO")]
        public int Grupo { get; set; }
        [Column("MODELO")]
        public int Modelo { get; set; }
        [Column("CANTID")]
        public float? Cantid { get; set; }
        [Column("DESCRI")]
        [StringLength(250)]
        public string Descri { get; set; }
        [Column("PLANTI")]
        public short? Planti { get; set; }
    }
}

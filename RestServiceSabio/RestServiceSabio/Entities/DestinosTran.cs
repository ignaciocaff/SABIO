using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DESTINOS_TRAN")]
    public partial class DestinosTran
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("SERVER")]
        [StringLength(100)]
        public string Server { get; set; }
        [Column("BASE")]
        [StringLength(200)]
        public string Base { get; set; }
        [Column("PUERTO")]
        public int? Puerto { get; set; }
        [Column("USUARI")]
        [StringLength(40)]
        public string Usuari { get; set; }
        [Column("PASSWD")]
        [StringLength(40)]
        public string Passwd { get; set; }
    }
}

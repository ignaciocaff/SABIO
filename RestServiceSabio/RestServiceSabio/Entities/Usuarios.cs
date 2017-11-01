using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("USUARIOS")]
    public partial class Usuarios
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("LOGIN")]
        [StringLength(10)]
        public string Login { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Required]
        [Column("CLAVE")]
        [StringLength(40)]
        public string Clave { get; set; }
        [Column("AREA")]
        public short Area { get; set; }
        [Column("HABILI")]
        public short? Habili { get; set; }
        [Column("UNINEG")]
        public short Unineg { get; set; }
        [Column("ESROOT")]
        public short? Esroot { get; set; }
        [Column("PATH")]
        [StringLength(200)]
        public string Path { get; set; }
        [Column("URL")]
        [StringLength(200)]
        public string Url { get; set; }
        [Column("DEPOSI")]
        public short Deposi { get; set; }
        [Column("EMAIL")]
        [StringLength(40)]
        public string Email { get; set; }
        [Column("PTOVTA")]
        public short? Ptovta { get; set; }
    }
}

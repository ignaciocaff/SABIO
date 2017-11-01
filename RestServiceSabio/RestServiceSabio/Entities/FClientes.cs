using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("F_CLIENTES")]
    public partial class FClientes
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(80)]
        public string Nombre { get; set; }
        [Column("CANAL")]
        public int Canal { get; set; }
        [Column("CUENTA")]
        public int Cuenta { get; set; }
        [Column("ENVIOS")]
        [StringLength(40)]
        public string Envios { get; set; }
    }
}

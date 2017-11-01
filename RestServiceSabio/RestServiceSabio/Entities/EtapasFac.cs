using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ETAPAS_FAC")]
    public partial class EtapasFac
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("CUENTA")]
        public int? Cuenta { get; set; }
        [Column("MARCA")]
        public short? Marca { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETCOMPXNOCONART")]
    public partial class Detcompxnoconart
    {
        [Key]
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("NUMERO")]
        public int? Numero { get; set; }
        [Column("NUMPRO")]
        public short? Numpro { get; set; }
        [Column("CODINS")]
        [StringLength(20)]
        public string Codins { get; set; }
        [Column("OPCION")]
        public short? Opcion { get; set; }
        [Column("CONOPC")]
        public short? Conopc { get; set; }
        [Column("FORMUL")]
        [StringLength(250)]
        public string Formul { get; set; }
    }
}

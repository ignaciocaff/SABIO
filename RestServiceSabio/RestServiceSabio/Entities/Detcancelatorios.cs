using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETCANCELATORIOS")]
    public partial class Detcancelatorios
    {
        [Column("NUMINT")]
        public int Numint { get; set; }
        [Column("ORIGEN")]
        public int Origen { get; set; }
        [Column("DESTIN")]
        public int Destin { get; set; }

        [ForeignKey("Origen,Destin")]
        [InverseProperty("Detcancelatorios")]
        public Detaplicaciones Detaplicaciones { get; set; }
        [ForeignKey("Numint")]
        [InverseProperty("Detcancelatorios")]
        public Cancelatorios NumintNavigation { get; set; }
    }
}

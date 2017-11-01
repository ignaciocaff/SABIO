using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("DETAPLICACIONES")]
    public partial class Detaplicaciones
    {
        public Detaplicaciones()
        {
            Detcancelatorios = new HashSet<Detcancelatorios>();
        }

        [Column("ORIGEN")]
        public int Origen { get; set; }
        [Column("DESTIN")]
        public int Destin { get; set; }
        [Column("NRODES")]
        [StringLength(1024)]
        public string Nrodes { get; set; }

        [InverseProperty("Detaplicaciones")]
        public ICollection<Detcancelatorios> Detcancelatorios { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("ASIENTOSMODELOS")]
    public partial class Asientosmodelos
    {
        public Asientosmodelos()
        {
            Detasientosmodelos = new HashSet<Detasientosmodelos>();
        }

        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(60)]
        public string Nombre { get; set; }

        [InverseProperty("NumeroNavigation")]
        public ICollection<Detasientosmodelos> Detasientosmodelos { get; set; }
    }
}

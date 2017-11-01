using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("TIPOSCODBARRA")]
    public partial class Tiposcodbarra
    {
        [Key]
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NOMBRE")]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Column("DESCRI")]
        [StringLength(200)]
        public string Descri { get; set; }
        [Column("LARTOT")]
        public short? Lartot { get; set; }
        [Column("UCODPR")]
        public short? Ucodpr { get; set; }
        [Column("LCODPR")]
        public short? Lcodpr { get; set; }
        [Column("UBICAN")]
        public short? Ubican { get; set; }
        [Column("LARCAN")]
        public short? Larcan { get; set; }
        [Column("UBIPRE")]
        public short? Ubipre { get; set; }
        [Column("LARPRE")]
        public short? Larpre { get; set; }
        [Column("UBIPES")]
        public short? Ubipes { get; set; }
        [Column("LARPES")]
        public short? Larpes { get; set; }
        [Column("UFECEL")]
        public short? Ufecel { get; set; }
        [Column("LFECEL")]
        public short? Lfecel { get; set; }
        [Column("UFECVE")]
        public short? Ufecve { get; set; }
        [Column("LFECVE")]
        public short? Lfecve { get; set; }
        [Column("UDIGVE")]
        public short? Udigve { get; set; }
        [Column("LDIGVE")]
        public short? Ldigve { get; set; }
        [Column("UNUSER")]
        public short? Unuser { get; set; }
        [Column("LNUSER")]
        public short? Lnuser { get; set; }
        [Column("CANTDECPESO")]
        public short? Cantdecpeso { get; set; }
    }
}

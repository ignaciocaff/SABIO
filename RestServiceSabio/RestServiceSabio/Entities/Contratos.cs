using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestServiceSabio.Entities
{
    [Table("CONTRATOS")]
    public partial class Contratos
    {
        [Key]
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("NUMCLI")]
        public int? Numcli { get; set; }
        [Column("TIPO")]
        public short? Tipo { get; set; }
        [Column("FECHA", TypeName = "DATE")]
        public DateTime? Fecha { get; set; }
        [Column("ESTADO")]
        public short? Estado { get; set; }
        [Column("PRODUC")]
        [StringLength(20)]
        public string Produc { get; set; }
        [Column("DESCRI")]
        [StringLength(250)]
        public string Descri { get; set; }
        [Column("VENDED")]
        public short? Vended { get; set; }
        [Column("OBSERV", TypeName = "VARCHAR(10240)")]
        public string Observ { get; set; }
        [Column("USAMAR")]
        [StringLength(40)]
        public string Usamar { get; set; }
        [Column("USAMOD")]
        [StringLength(40)]
        public string Usamod { get; set; }
        [Column("USAKIL")]
        public int? Usakil { get; set; }
        [Column("CONYUG")]
        public int? Conyug { get; set; }
        [Column("CODRAP")]
        [StringLength(20)]
        public string Codrap { get; set; }
        [Column("CODPAF")]
        [StringLength(20)]
        public string Codpaf { get; set; }
        [Column("DEBITA")]
        public short? Debita { get; set; }
        [Column("TARJET")]
        public short? Tarjet { get; set; }
        [Column("ADJUDI")]
        public short? Adjudi { get; set; }
        [Column("DIACOB")]
        public short? Diacob { get; set; }
        [Column("NROTAR")]
        [StringLength(40)]
        public string Nrotar { get; set; }
        [Column("SCORIN")]
        public short? Scorin { get; set; }
        [Column("AUTPLA")]
        public short? Autpla { get; set; }
        [Column("FECCUO", TypeName = "DATE")]
        public DateTime? Feccuo { get; set; }
        [Column("PROPUE")]
        [StringLength(100)]
        public string Propue { get; set; }
    }
}

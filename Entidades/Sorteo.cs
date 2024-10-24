using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakaoCasino.Entidades
{
    public class Sorteo
    {
        [Key]
        [Column("SorteoId")]
        public int Id { get; set; }
        public string NombreDeSorteo { get; set; }
        public int SedeId { get; set; }
        public int TipoDeSorteoId { get; set; }
        public int UsuarioCreadorId { get; set; }
        public DateTime? FechaDeCreacion { get; set; }
        public virtual Sede Sede { get; set; }
        public virtual TiposDeSorteo TiposDeSorteo { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}

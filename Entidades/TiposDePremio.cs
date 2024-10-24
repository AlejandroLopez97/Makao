using System.ComponentModel.DataAnnotations.Schema;

namespace MakaoCasino.Entidades
{
    public class TiposDePremio
    {
        [Column("TiposDePremioId")]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public DateTime? FechaDeCreacion { get; set; }
        public int? UsuarioCreadorId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}

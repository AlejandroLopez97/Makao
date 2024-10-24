using System.ComponentModel.DataAnnotations.Schema;

namespace MakaoCasino.Entidades
{
    public class Premio
    {
        [Column("PremioId")]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Valor { get; set; }
        public int TipoDePremioId { get; set; }
        public bool Activo { get; set; }
        public DateTime? FechaDeCreacion { get; set; }
        public int UsuarioCreadorId { get; set; }
        public virtual TiposDePremio TiposDePremio { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}

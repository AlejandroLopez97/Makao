namespace MakaoCasino.Entidades
{
    public class EntregasDePremio
    {
        [Column("EntregasDePremioId")]
        public int Id { get; set; }
        public virtual Sorteo Sorteo { get; set; }
        public int SorteId { get; set; }
        public virtual Premio Premio { get; set; }
        public int PremioId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int? ClienteId { get; set; }
        public DateTime? FechaDeCreacion { get; set; }
        public int? UsuarioCreadorId { get; set; }
    }
}

namespace MakaoCasino.Entidades
{
    public class TipoDeIdentificacion
    {
        [Column("TipoDeIdentificacionId")]
        public int Id { get; set; }
        public string NombreDeIdentificacion { get; set; }
        public DateTime? FechaDeCreacion { get; set; }

    }
}

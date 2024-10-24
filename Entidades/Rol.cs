namespace MakaoCasino.Entidades
{
    public class Rol
    {
        [Column("RolId")]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaDeCreacion { get; set; }
    }
}

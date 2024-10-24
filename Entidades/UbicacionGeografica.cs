using System.ComponentModel.DataAnnotations.Schema;

namespace MakaoCasino.Entidades
{
    public class UbicacionGeografica
    {
        [Column("UbicacionGeograficaId")]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? PadreId { get; set; }
        public string CodigoPostal { get; set; }
        public DateTime? FechaDeCreacion { get; set; }
    }
}

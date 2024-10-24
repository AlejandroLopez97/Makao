using Microsoft.Build.Evaluation;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakaoCasino.Entidades
{
    public class Cargo
    {
        [Column("CargoId")]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaDeCreacion { get; set; }
    }
}

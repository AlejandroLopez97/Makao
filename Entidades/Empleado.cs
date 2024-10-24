using System.ComponentModel.DataAnnotations.Schema;

namespace MakaoCasino.Entidades
{
    public class Empleado
    {
        [Column("EmpleadoId")]
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public int? CargoId { get; set; }
        public int? SedeId { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual Cargo Cargo { get; set; }
        public virtual Sede Sede { get; set; }
    }
}

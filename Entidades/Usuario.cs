using System.ComponentModel.DataAnnotations.Schema;

namespace MakaoCasino.Entidades
{
    public class Usuario
    {
        [Column("UsuarioId")]
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaDeCreacion { get; set; }
        public DateTime FechaDeCambioContrasenia { get; set; }
        public bool Activo { get; set; }

        //Relacion con persona
        public virtual Persona Persona { get; set; }
    }
}

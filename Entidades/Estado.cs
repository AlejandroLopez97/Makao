using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakaoCasino.Entidades
{
    public class Estado
    {
        [Key]
        [Column("EstadoId")]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdEnLaAplicacion { get; set; }
        public int Categoria { get; set; }
        public bool Activo { get; set; }
        public DateTime? FechaDeCreacion { get; set; }

    }
}

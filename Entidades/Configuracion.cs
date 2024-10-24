using System.ComponentModel.DataAnnotations.Schema;

namespace MakaoCasino.Entidades
{
    public class Configuracion
    {
        [Column("ConfiguracionId")]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Valor { get; set; }
        public bool Activo { get; set; }
        public int? FechaDeCreacion { get; set; }
    }
}

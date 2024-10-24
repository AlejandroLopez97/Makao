using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakaoCasino.Entidades
{
    public class Sede
    {
        [Key]
        [Column("SedeId")]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }   
        public int? CantidadDeMaquinas { get; set; }
        public int? UbicacionGeograficaId { get; set; }
        public virtual UbicacionGeografica UbicacionGeografica { get; set; }
        public virtual ICollection<Maquina> Maquinas { get; set; }
    }
}

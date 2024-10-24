namespace MakaoCasino.Entidades
{
    public class Maquina
    {
        [Column("MaquinaId")]
        public int Id { get; set; }
        public string NumeroDeMaquina { get; set; }
        public string Descripcion { get; set; }
        public int SedeId { get; set; }
        public int EstadoId { get; set; }
        public virtual Sede Sede { get; set; }
        public virtual Estado Estado { get; set;}
    }
}

namespace MakaoCasino.Entidades
{
    public class Cliente
    {
        [Column("ClienteId")]
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public int? SedeId { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual Sede Sede { get; set; }
    }
}

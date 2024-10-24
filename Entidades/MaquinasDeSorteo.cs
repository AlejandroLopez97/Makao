namespace MakaoCasino.Entidades
{
    public class MaquinasDeSorteo
    {
        public virtual Sorteo Sorteo { get; set; }
        public int SorteoId { get; set; }
        public virtual Maquina Maquina { get; set; }
        public int MaquinaId { get; set; }
    }
}

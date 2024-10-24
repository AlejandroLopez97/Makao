namespace MakaoCasino.Entidades
{
    public class PremiosDeSorteo
    {
        public virtual Sorteo Sorteo { get; set; }
        public int SorteoId { get; set; }
        public virtual Premio Premio { get; set; }
        public int PremioId { get; set; }
    }
}

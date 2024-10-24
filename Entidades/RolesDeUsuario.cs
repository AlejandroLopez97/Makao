namespace MakaoCasino.Entidades
{
    public class RolesDeUsuario
    {
        public virtual Rol Rol { get; set; }
        public int RolId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MakaoCasino.Entidades;
using Microsoft.Build.ObjectModelRemoting;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

namespace MakaoCasino.Data
{
    public class MakaoDbContext : IdentityDbContext
    {
        public MakaoDbContext(DbContextOptions<MakaoDbContext> options)
            : base(options)
        { }

        //Agregamos los DBSet para cada entidad
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Sede> Sedes { get; set; } 
        public DbSet<UbicacionGeografica> UbicacionGeograficas { get; set; }
        public DbSet<TipoDeIdentificacion> TipoDeIndentificaciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<RolesDeUsuario> RolesDeUsuarios { get; set; }
        public DbSet<Maquina> Maquinas { get; set; }
        public DbSet<Sorteo> Sorteos { get; set; }
        public DbSet<Premio> Premios { get; set; }
        public DbSet<TiposDePremio> TiposDePremios { get; set; }
        public DbSet<TiposDeSorteo> TiposDeSorteos { get; set; }
        public DbSet<Configuracion> Configuraciones { get; set; }
        public DbSet<EntregasDePremio> EntregasDePremios { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<MaquinasDeSorteo> MaquinasDeSorteos { get; set; }
        public DbSet<PremiosDeSorteo> PremiosDeSorteos { get; set; }

        //Habilitar la carga perezosa para las propiedades virtuales
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            //base.OnConfiguring(optionsBuilder);
        }

        //Se sobreescribe onModelCreating para configurar las relaciones con fluent API
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Configuracion de llaves compuestas
            builder.Entity<Cliente>()
                .Haskey(x => new {x.Id, x.PersonaId});

            builder.Entity<Empleado>()
                .HasKey(x => new {x.Id, x.PersonaId});

        }


    }
}
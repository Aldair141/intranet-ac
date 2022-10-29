using IntranetAC.Modelos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IntranetAC.AccesoDatos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<UsuarioAplicacion> UsuarioAplicacion { get; set; }
        public DbSet<Socio> Socio { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
        public DbSet<Membresia> Membresia { get; set; }
        public DbSet<MembresiaEstado> MembresiaEstado { get; set; }
        public DbSet<TipoPago> TipoPago { get; set; }
        public DbSet<Pago> Pago { get; set; }
        public DbSet<AreaEstado> AreaEstado { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<UnidadLongitud> UnidadLongitud { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
    }
}
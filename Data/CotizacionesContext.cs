using Microsoft.EntityFrameworkCore;
using Cotizaciones.Models;

namespace Cotizaciones.Data {
    public class CotizacionesContext : DbContext
    {
        public CotizacionesContext(DbContextOptions<CotizacionesContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Utilizacion de SQLite como backend
            optionsBuilder.UseSqlite("Data Source=cotizaciones.db");
        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Cotizacion> Cotizaciones { get; set; }
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Usuario> Usuarios {get; set;}


    }
}
using Microsoft.EntityFrameworkCore;
using Vehiculos.App.Dominio;

namespace Vehiculos.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> personas {get; set;}
        public DbSet<Duenio> duenios {get; set;}
        public DbSet<Conductor> Conductores {get; set;}
        public DbSet<Mecanico> Mecanicos {get; set;}
        public DbSet<cliente> Clientes {get; set;} 
        public DbSet<VehiculosTransporte> Vehiculos  {get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog = VehiculosData");

                optionsBuilder.Entity<Servicios>().HasRequired(x=> x.cliente)
                optionsBuilder.Entity<Servicios>().HasRequired(x=> x.cliente)
            }
        }
    }
}
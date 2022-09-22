using Microsoft.EntityFrameworkCore;
using Equus.App.Dominio;
namespace Equus.App.Persistencia;

public class AppContext : DbContext
{
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Animal> Animales { get; set; }
    public DbSet<Veterinario> Veterinarios { get; set; }
    public DbSet<Propietario> Propietarios { get; set; }
    public DbSet<HistoriaClinica> HistoriasClinicas { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source=(localdb)\\ MSSQLLocalDB;Initial Catalog= Equus");
        }
    }
}


using CatalogoMusicas.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogoMusicas.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        
        public DbSet<Musica> Musica { get; set; }
        public DbSet<Podcast> Podcast { get; set; }

    }
}

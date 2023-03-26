namespace Firma.Data.Data
{
    public class FirmaContext : DbContext
    {
        public FirmaContext(DbContextOptions<FirmaContext> options)
            : base(options)
        {
        }

        public DbSet<Strona> Strona { get; set; } = default!;

        public DbSet<Aktualnosc> Aktualnosc { get; set; }
        public DbSet<Rodzaj> Rodzaj { get; set; }
        public DbSet<Towar> Towar { get; set; }
    }
}

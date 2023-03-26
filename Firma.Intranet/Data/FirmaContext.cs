using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Firma.Intranet.Models.CMS;

namespace Firma.Intranet.Data
{
    public class FirmaContext : DbContext
    {
        public FirmaContext (DbContextOptions<FirmaContext> options)
            : base(options)
        {
        }

        public DbSet<Firma.Intranet.Models.CMS.Strona> Strona { get; set; } = default!;

        public DbSet<Firma.Intranet.Models.CMS.Aktualnosc> Aktualnosc { get; set; }
    }
}

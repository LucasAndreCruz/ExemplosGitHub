using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppExercicioPratico.Models
{
    public class AutomovelContext : DbContext
    {
        public AutomovelContext (DbContextOptions<AutomovelContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppExercicioPratico.Models.Automovel> Automovel { get; set; }
    }
}

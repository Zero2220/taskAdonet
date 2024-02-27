using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace taskentity
{
    internal class AppDbContext: DbContext
    {
        public DbSet<Brands> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-J30FIEB\\SQLEXPRESS;Database=BrandsDb;TrustServerCertificate=true");
        }

    }
}

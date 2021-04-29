using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseManagement2.Models
{
    public class StockDbcontext : DbContext
    {
        public DbSet<Stock> Stocks { get; set; }

        public StockDbcontext(DbContextOptions<StockDbcontext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>().ToTable("Warehouse");
        }
    }
}

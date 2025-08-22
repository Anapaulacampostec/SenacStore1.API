using Microsoft.EntityFrameworkCore;
using SenacStore1.API.Models;

namespace SenacStore1.API.Data
{  
    public class SenacStore1DbContext : DbContext
    {
        public SenacStore1DbContext(DbContextOptions<SenacStore1DbContext> options):base(options) { }

        //models
        public DbSet<Produto> Produtos { get; set; }
    }
}

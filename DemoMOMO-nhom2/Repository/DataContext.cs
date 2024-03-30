using DemoMOMO_nhom2.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMOMO_nhom2.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<BrandModel> Brands { get; set;}
        public DbSet<ProductModel> Products { get; set;}
        public DbSet<CategotyModel> Categories { get; set;}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
        }

	}
}

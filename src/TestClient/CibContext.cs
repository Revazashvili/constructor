using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TestClient.Entities;

namespace TestClient
{
    public class CibContext : DbContext
    {
        public CibContext(DbContextOptions<CibContext> options) : base(options)
        {
        }

        public DbSet<Test> Tests { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerResponse> CustomerResponses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
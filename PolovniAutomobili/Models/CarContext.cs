using Microsoft.EntityFrameworkCore;

namespace PolovniAutomobili.Models
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CarContext()
        {
        }

        public CarContext(DbContextOptions<CarContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=PolovniAutomobili;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}

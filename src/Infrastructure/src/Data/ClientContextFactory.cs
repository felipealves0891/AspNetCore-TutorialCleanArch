using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Infrastructure.src.Data
{
    public class ClientContextFactory : IDesignTimeDbContextFactory<ClientContext>
    {
        public ClientContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ClientContext>();
            optionsBuilder.UseSqlServer("Server=LAPTOP-FHTKFNSI\\DB1;Database=DBTutorialCleanArch;Trusted_Connection=True");

            return new ClientContext(optionsBuilder.Options);
        }
    }
}
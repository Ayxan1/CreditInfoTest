using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.ApplicationDataContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
            
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractData> ContractDatas { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<SubjectRole> SubjectRoles { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<PhaseOfContract> PhaseOfContracts { get; set; }
        public DbSet<Gender> Genders { get; set; }
    }
}

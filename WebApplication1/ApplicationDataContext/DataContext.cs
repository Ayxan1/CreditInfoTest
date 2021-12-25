using Microsoft.EntityFrameworkCore;

namespace WebApplication1.ApplicationDataContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Situationships.API.Entities;

namespace Situationships.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}
using EczaneApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EczaneApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Eczane> Eczanes { get; set; }
    }
}
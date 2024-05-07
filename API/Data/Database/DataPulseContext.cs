using API.Data.Entities.DesignPattern.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data.DataBase
{
    public class DataPulseContext : DbContext
    {
        public DataPulseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DesignPatternEntity> DesignPatterns { get; set; }
    }
}
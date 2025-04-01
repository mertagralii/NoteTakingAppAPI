using Microsoft.EntityFrameworkCore;
using NoteTakingAppAPI.Model;

namespace NoteTakingAppAPI.Data
{
    public class APİDatabaseContent : DbContext
    {
        public APİDatabaseContent(DbContextOptions<APİDatabaseContent> options) : base(options)
        {
        }
        public DbSet<Note> Notes { get; set; }
    }
}

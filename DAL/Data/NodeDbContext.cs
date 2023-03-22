using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
    public sealed class NodeDbContext : DbContext
    {
        public NodeDbContext(DbContextOptions<NodeDbContext> options) : base(options)
        { }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}

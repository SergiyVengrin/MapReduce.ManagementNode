using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Entitites
{
    public partial class MapReduceDBContext : DbContext
    {
        public MapReduceDBContext()
        {
        }

        public MapReduceDBContext(DbContextOptions<MapReduceDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NodesMetadata> NodesMetadata { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NodesMetadata>(entity =>
            {
                entity.HasKey(e => e.NodeId);
                entity.Property(e => e.NodeFolder).HasMaxLength(200);
                entity.Property(e => e.NodeUrl).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

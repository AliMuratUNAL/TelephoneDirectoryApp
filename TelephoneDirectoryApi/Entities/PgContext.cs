using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace TelephoneDirectoryApi.Entities
{
    public class PgContext : DbContext
    {
        public PgContext(DbContextOptions<PgContext> options) : base(options)
        {

        }

        public DbSet<TelephoneDirectory> TelephoneDirectorys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PgContext).Assembly);
            //base.OnModelCreating(modelBuilder);
        }


    }
}

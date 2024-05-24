using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using TelephoneDirectoryData.Entities;

namespace TelephoneDirectoryData.DataAccess
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

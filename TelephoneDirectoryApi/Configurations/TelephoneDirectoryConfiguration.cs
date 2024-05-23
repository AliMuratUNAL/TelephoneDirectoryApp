using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TelephoneDirectoryApi.Entities;

namespace TelephoneDirectoryApi.Configurations
{
    public class TelephoneDirectoryConfiguration : IEntityTypeConfiguration<TelephoneDirectory>
    {
        public void Configure(EntityTypeBuilder<TelephoneDirectory> builder)
        {
            builder.Property(s => s.Name).HasMaxLength(255);
            builder.Property(s => s.SurName).HasMaxLength(255);
            builder.Property(s => s.Company).HasMaxLength(255);
            builder.Property(s => s.CommunicationInformation).HasMaxLength(255);
            builder.Property(s => s.InformationContent).HasMaxLength(255);
            builder.Property(s => s.Report).HasMaxLength(255);
        }
    }
}

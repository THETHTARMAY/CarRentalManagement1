using CarRentalManagement1.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement1.Configurations.Entities
{
    public class MakeSeed : IEntityTypeConfiguration<Make>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make
                {
                    Id = 1,
                    Name = "BMW",
                    DateCreated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Make
                {
                    Id = 2,
                    Name = "Toyota",
                    DateCreated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}

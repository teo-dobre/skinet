using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole { Id = "e1fa36bf-67ec-48cd-9b4f-ad20094d4241", Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole { Id = "86cd53dd-918c-4914-8cd2-db36b5bee998", Name = "Customer", NormalizedName = "CUSTOMER" }
        );
    }
}

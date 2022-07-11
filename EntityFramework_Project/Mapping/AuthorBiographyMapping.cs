using EntityFramework_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework_Project.Mapping
{
    public class AuthorBiographyMapping:IEntityTypeConfiguration<AuthorBiography>
    {
        public void Configure(EntityTypeBuilder<AuthorBiography> builder)
        {
            builder.ToTable("AuthorBiographies");
            builder.HasKey(x => x.Id);
        }
    }
}

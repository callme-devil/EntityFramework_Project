using EntityFramework_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework_Project.Mapping
{
    public class AuthorMapping:IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Biography)
                .WithOne(x => x.Author)
                .HasForeignKey<AuthorBiography>(x => x.AuthorId);
        }
    }
}

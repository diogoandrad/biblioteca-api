using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BIBLIOTECA.Domain.Entities;

namespace BIBLIOTECA.Infrastructure.Mappings
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("books");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedNever().IsRequired();
            builder.Property(x => x.Title).HasColumnName("title").IsRequired();
            builder.Property(x => x.Caption).HasColumnName("caption").IsRequired();
            builder.Property(x => x.Pages).HasColumnName("pages").IsRequired();
            builder.Property(x => x.Year).HasColumnName("year").IsRequired();
            builder.Property(x => x.Version).HasColumnName("version").IsRequired();
            builder.Property(x => x.Authors).HasColumnName("authors").IsRequired();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CslAppEntityFrameworkCore.Models.Mappings
{
    public class PeopleMap : IEntityTypeConfiguration<People>
    {
        public void Configure(EntityTypeBuilder<People> builder)
        {
            builder.ToTable("peoples");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                    .HasColumnName("id");
            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasMaxLength(100);
            builder.HasOne(x => x.Address)
                .WithOne(x => x.People)
                .HasPrincipalKey<People>(c => c.Id)
                .HasForeignKey<Address>(c => c.PeopleId)
                .IsRequired();
        }
    }
}

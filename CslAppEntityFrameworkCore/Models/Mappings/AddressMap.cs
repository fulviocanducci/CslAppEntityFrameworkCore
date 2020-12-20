using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CslAppEntityFrameworkCore.Models.Mappings
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("address");
            builder.HasKey(x => x.PeopleId);
            builder.Property(x => x.PeopleId)
                    .HasColumnName("peopleId");
            builder.Property(x => x.Street)
                    .HasColumnName("street")
                    .HasMaxLength(100)
                    .IsRequired();
            builder.Property(x => x.Number)
                    .HasColumnName("number")
                    .HasMaxLength(30)
                    .IsRequired();            
        }
    }
}

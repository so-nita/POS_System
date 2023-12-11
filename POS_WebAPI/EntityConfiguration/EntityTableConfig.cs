using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS_WebAPI.Models.EntityModel;

namespace POS_WebAPI.EntityConfiguration
{
    public class EntityTableConfig : IEntityTypeConfiguration<Table>
    {
        public void Configure(EntityTypeBuilder<Table> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.Name).IsRequired().HasColumnType("varchar").HasMaxLength(100);
            builder.Property(e => e.Name).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            builder.Property(e => e.Description).IsRequired(false).HasColumnType("varchar");
            builder.Property(e => e.Create_At).IsRequired().HasColumnType("datetime");
            builder.Property(e => e.Status).IsRequired().HasColumnType("int").HasConversion<int>();
            builder.Property(e => e.Is_Deleted).IsRequired(false).HasColumnType("bit");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS_WebAPI.Models.EntityModel;

namespace POS_WebAPI.EntityConfiguration
{
    public class EntityOrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.Customer_Id).IsRequired(false).HasColumnType("varchar").HasMaxLength(36); 
            builder.Property(e => e.Table_Id).IsRequired(false).HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.User_Id).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.CustomerName).IsRequired().HasColumnType("varchar").HasMaxLength(100);
            builder.Property(e => e.TotalItem).IsRequired().HasColumnType("int");
            builder.Property(e => e.Total).IsRequired().HasColumnType("decimal(8,2)");
            builder.Property(e => e.Total).IsRequired().HasColumnType("decimal(8,2)");
            builder.Property(e => e.OrderStatus).IsRequired().HasColumnType("int").HasConversion<int>();

            builder.HasOne(e => e.Customer)
                   .WithMany(e => e.Orders)
                   .HasForeignKey(x => x.Customer_Id)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Table)
                   .WithMany(e => e.Orders)
                   .HasForeignKey(x => x.Table_Id)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.User)
                   .WithMany(e => e.Orders)
                   .HasForeignKey(x => x.User_Id)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

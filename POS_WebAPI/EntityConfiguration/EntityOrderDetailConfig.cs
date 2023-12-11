using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS_WebAPI.Models.EntityModel;

namespace POS_WebAPI.EntityConfiguration
{
    public class EntityOrderDetailConfig : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.Product_Id).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.Order_Id).IsRequired().HasColumnType("varchar").HasMaxLength(36);
            builder.Property(e => e.Product_Name).IsRequired().HasColumnType("varchar").HasMaxLength(100);
            builder.Property(e => e.Size).IsRequired().HasColumnType("varchar").HasMaxLength(100);
            builder.Property(e => e.Price).IsRequired().HasColumnType("decimal(8,2)");
            builder.Property(e => e.Qty).IsRequired().HasColumnType("int");
            builder.Property(e => e.GrandTotal).IsRequired().HasColumnType("decimal(8,2)");
            builder.Property(e => e.Tax).IsRequired().HasColumnType("decimal(8,2)");
            builder.Property(e => e.Total).IsRequired().HasColumnType("decimal(8,2)");
            builder.Property(e => e.Create_At).IsRequired().HasColumnType("datetime");
            //
            builder.HasOne(e=>e.Order)
                   .WithMany(e=>e.OrderDetails)
                   .HasForeignKey(x => x.Order_Id)
                   .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.Product)
                   .WithMany(e => e.OrderDetails)
                   .HasForeignKey(x => x.Product_Id)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

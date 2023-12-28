using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using POS_WebAPI.Models.Constant;
using POS_WebAPI.Models.EntityModel;

namespace POS_WebAPI.EntityConfiguration
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            builder.Property(e => e.Company_Id).IsRequired(false)
                                                .HasColumnType("varchar")
                                                .HasMaxLength(36); 

            builder.Property(e => e.Source_Id).IsRequired(false)
                                                .HasColumnType("varchar")
                                                .HasMaxLength(36);

            builder.Property(e => e.Reference_Id).IsRequired(false)
                                                .HasColumnType("varchar")
                                                .HasMaxLength(36);

            builder.Property(e => e.Tax).IsRequired(false).HasColumnType("decimal(8,2)");

            builder.Property(e => e.Total_Discount).IsRequired()
                                                .HasColumnType("decimal(8,2)");

            builder.Property(e => e.Grand_Total).IsRequired().HasColumnType("decimal(8,2)");

            builder.Property(e => e.Sub_Total).IsRequired()
                                                .HasColumnType("decimal(8,2)");

            builder.Property(e => e.Order_Status).IsRequired()
                                                .HasColumnType("int")
                                                .HasConversion<int>();

            builder.Property(e => e.Order_Date).IsRequired()
                                                .HasColumnType("datetime");
            builder.Property(e => e.Is_Delete).IsRequired()
                                                .HasColumnType("bit");

            // section
            builder.HasOne(e => e.Source)
                   .WithMany(e => e.Orders)
                   .HasForeignKey(x => x.Source_Id)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.User)
                   .WithMany(e => e.Orders)
                   .HasForeignKey(x => x.Reference_Id)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

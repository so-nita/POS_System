using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS_WebAPI.Models.EntityModel;

namespace POS_WebAPI.EntityConfiguration
{
    public class ReceiptConfig : IEntityTypeConfiguration<Receipt>
    {
        public void Configure(EntityTypeBuilder<Receipt> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired()
                                        .HasColumnType("varchar")
                                        .HasMaxLength(36);

            builder.Property(e => e.Order_Id).IsRequired(false)
                                                .HasColumnType("varchar")
                                                .HasMaxLength(36);

            builder.Property(e => e.Reference).IsRequired(false)
                                                .HasColumnType("varchar")
                                                .HasMaxLength(36);

            builder.Property(e => e.Discount).IsRequired()
                                                .HasColumnType("decimal(8,2)");

            builder.Property(e => e.Total).IsRequired()
                                                .HasColumnType("decimal(8,2)");

            builder.Property(e => e.Transaction_Date).IsRequired()
                                                .HasColumnType("datetime");

            builder.HasOne(e => e.Order)
                   .WithMany(e => e.Receipts)
                   .HasForeignKey(x => x.Order_Id)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.User)
                   .WithMany(e => e.Receipts)
                   .HasForeignKey(x => x.Reference)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS_WebAPI.Models.EntityModel;

namespace POS_WebAPI.EntityConfiguration
{
    public class EntitySubCategory : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Name).IsUnique();

            builder.Property(e => e.Id)
                   .IsRequired()
                   .HasColumnType("varchar") 
                   .HasMaxLength(36);

            builder.Property(e => e.Name)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.Property(e => e.Image)
                   .IsRequired(false)
                   .HasColumnType("varchar")
                   .HasMaxLength(550);

            builder.Property(e => e.Main_Category_Id)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(36);

            builder.Property(e => e.Description)
                   .IsRequired(false)
                   .HasColumnType("varchar")
                   .HasMaxLength(255);

            builder.Property(e => e.Create_At)
                   .IsRequired()
                   .HasColumnType("datetime");

            builder.Property(e => e.Status)
                   .IsRequired()
                   .HasColumnType("int")
                   .HasConversion<int>();

            builder.Property(e => e.Is_Deleted)
                   .IsRequired()
                   .HasColumnType("bit");

            builder.HasOne(e=>e.Category)
                   .WithMany(e=>e.SubCategories)
                   .HasForeignKey(x => x.Main_Category_Id)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

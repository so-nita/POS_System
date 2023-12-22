using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS_WebAPI.Models.Constant;
using POS_WebAPI.Models.EntityModel;

namespace POS_WebAPI.DataConfiguration
{
    public class UserLogConfig : IEntityTypeConfiguration<UserLog>
    {
        public void Configure(EntityTypeBuilder<UserLog> builder)
        {
            builder.ToTable("User_Logs");
            builder.HasKey(t => t.Id);

            builder.Property(e => e.Id)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(36);

            builder.Property(e => e.User_Id)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(36);

            builder.Property(e => e.User_Name)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.Property(e => e.User_Type)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.Property(e => e.Action)
                   .IsRequired()
                   .HasColumnType("int")
                   .HasConversion<int>();

            builder.Property(e => e.Create_At).IsRequired().HasColumnType("datetime");


            builder.HasOne(e => e.User)
                   .WithMany(e => e.UserLog)
                   .HasForeignKey(x => x.User_Id)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

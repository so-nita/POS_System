using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS_WebAPI.Models.EntityModel;

namespace POS_WebAPI.DataConfiguration
{
    public class LoginTransactionConfig : IEntityTypeConfiguration<LoginTransaction>
    {
        public User User { get; set; } = null!;
        public void Configure(EntityTypeBuilder<LoginTransaction> builder)
        {
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

            builder.Property(e => e.Login_At).IsRequired().HasColumnType("datetime");
            builder.Property(e => e.Logout_At).IsRequired().HasColumnType("datetime");


            builder.HasOne(e => e.User)
                   .WithMany(e => e.Logins)
                   .HasForeignKey(x => x.User_Id)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

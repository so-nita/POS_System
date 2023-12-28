using Microsoft.EntityFrameworkCore;
using POS_WebAPI.Models.EntityModel;
using POS_WebAPI.Models.RequestModel.SubCategory;
using System.Globalization;
using System.Reflection;

namespace POS_WebAPI.DataContext
{
    public class PosContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SystemType> SystemTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        //public DbSet<Table> Tables { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<UserLog> User_Logs { get; set; }


        public PosContext(DbContextOptions options) : base(options)
        {
        }
         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

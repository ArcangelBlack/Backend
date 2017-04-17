using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Microsoft.Azure.Mobile.Server.Tables;

namespace DeliverBackend.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("DefaultConnection")
        {
            Database.CommandTimeout = 300;
        }

        public static DataContext Create()
        {
            return new DataContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rol>().HasKey(a => a.Id);

            modelBuilder.Entity<Order>().HasKey(o => o.Id);

            modelBuilder.Entity<User>().HasKey(c => c.Id);

            modelBuilder.Entity<Product>().HasKey(p => p.Id);

            //string schema = System.Configuration.ConfigurationManager.AppSettings.Get("MS_MobileServiceName");
            //if (!string.IsNullOrEmpty(schema))
            //{
            //    // If the MS_MobileServiceName value has not been set in AppSettings (via Web.config or portal AppSettings), then the default schema will be used ("dbo").
            //    modelBuilder.HasDefaultSchema(schema);
            //}

            modelBuilder.Conventions.Add(
                new AttributeToColumnAnnotationConvention<TableColumnAttribute, string>(
                    "ServiceTableColumn", (property, attributes) => attributes.Single().ColumnType.ToString()));
        }

        public System.Data.Entity.DbSet<DeliverBackend.Models.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<DeliverBackend.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<DeliverBackend.Models.Card> Cards { get; set; }

        public System.Data.Entity.DbSet<DeliverBackend.Models.Transporter> Transporters { get; set; }

        public System.Data.Entity.DbSet<DeliverBackend.Models.Receiver> Receivers { get; set; }

        public System.Data.Entity.DbSet<DeliverBackend.Models.Rol> Rols { get; set; }

        public System.Data.Entity.DbSet<DeliverBackend.Models.Mobile> Mobiles { get; set; }

        public System.Data.Entity.DbSet<DeliverBackend.Models.Address> Addresses { get; set; }

        public System.Data.Entity.DbSet<DeliverBackend.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<DeliverBackend.Models.OrderDetail> OrderDetails { get; set; }
    }
}
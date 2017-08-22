namespace FIT5032_Week05.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Week05 : DbContext
    {
        public Week05()
            : base("name=Week05")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderSum)
                .HasPrecision(19, 4);
        }
    }
}

namespace LazyLoadingDemo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Products : DbContext
    {
        public Products()
            : base("name=Products")
        {
        }

        public virtual DbSet<Product> ProductsDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

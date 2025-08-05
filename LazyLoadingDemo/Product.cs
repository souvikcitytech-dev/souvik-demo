namespace LazyLoadingDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int Price { get; set; }

        public string ProductDescription { get; set; }
    }
}

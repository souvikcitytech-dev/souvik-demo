using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LazyLoadingDemo
{
    public class ProductRepository
    {
        private const int pageSize = 20;
        public List<Product> GetProducts(int? pageNumber)
        {
            var page = pageNumber ?? 0;
            var numberOfRecordToskip = page * pageSize;
            using (var context = new Products())
            {
                return context.ProductsDetails.OrderBy(x=>x.ProductID).Skip(Convert.ToInt32(numberOfRecordToskip)).Take(pageSize).ToList<Product>();
            }
        }
    }
}
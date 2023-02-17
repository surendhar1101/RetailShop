using RetailShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Service
{
    public interface IProductService
    {
        List<ProductViewModel> GetProducts();
        

         public void PostProduct(ProductViewModel product);

        ProductViewModel GetProducts(Guid id);

         public void PutProduct(Guid id,ProductViewModel product);

        public void DeleteProduct(Guid id);


    }
}

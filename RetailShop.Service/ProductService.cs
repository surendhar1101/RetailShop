using AutoMapper;
using Microsoft.Identity.Client;
using RetailShop.Model;
using RetailShop.Repository.Enitities;
using RetailShop.Repository.Implementation;
using RetailShop.Service;

namespace RetailShop.Service
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(ProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public List<ProductViewModel> GetProducts()
        {
            List<ProductViewModel> productlist = _productRepository.GetProductinrep();
            return productlist;
            
        }

     

        public ProductViewModel GetProducts(Guid id)
        {
            Product productList=_productRepository.GetProductinrep(id);
            ProductViewModel product=_mapper.Map<ProductViewModel>(productList);
            return product;
        }
        public void PostProduct(ProductViewModel product)
        {
            var Product1 = _mapper.Map<Product>(product);
            Product1.Id = Guid.NewGuid();
            _productRepository.Post(Product1);

        }

        public void PutProduct(Guid id,ProductViewModel product)
        {
            var productedit = _mapper.Map<Product>(product);
            _productRepository.Put(productedit);
        }
        public void DeleteProduct(Guid id)
        {
            _productRepository.Delete(id);

        }
       
  
            



    }
}

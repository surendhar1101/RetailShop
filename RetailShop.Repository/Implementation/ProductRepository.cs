using AutoMapper;
using RetailShop.Model;
using RetailShop.Repository.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Repository.Implementation
{
    public class ProductRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        public ProductRepository(AppDbContext dbContext,IMapper mapper) 
        {
            _mapper= mapper;
            _dbContext = dbContext;
        }
       public List<ProductViewModel> GetProductinrep()
        {
            var products = _dbContext.Products.ToList();
            List<ProductViewModel> productViewModels = _mapper.Map<List<ProductViewModel>>(products);
            return productViewModels;
        }
        public Product GetProductinrep(Guid id)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public  void Post(Product data)
        {

            _dbContext.Products.Add(data);
            _dbContext.SaveChanges();
        }
        public void Put(Product data)
        {
            _dbContext.Products.Update(data);
            _dbContext.SaveChanges();
        }
        public void Delete(Guid id)
        {
            var ProductDelete= _dbContext.Products.FirstOrDefault(x => x.Id == id);
            _dbContext.Products.Remove(ProductDelete);
            _dbContext.SaveChanges();
        }
       
        
    }
}


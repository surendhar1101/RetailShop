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
    public class mapper:Profile
    {
        public mapper()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
    }
}

using API.Dtos;
using AutoMapper;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            //Category nesnesi Category Dto ya dönüştür.
            CreateMap<Category, CategoryDto>();
            //CategoryDto Categorye dönüştür.
            CreateMap<CategoryDto, Category>();

            CreateMap<CategoryWithProductDto, Category>();
            CreateMap<Category, CategoryWithProductDto>();

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            

            CreateMap<ProductWithCategoryDto, Product>();
            CreateMap<Product, ProductWithCategoryDto>();

            CreateMap<ProductDto, Product>();
            CreateMap<Product, ProductDto>();
        }
    }
}

using AutoMapper;
using Multishop.Catalog.Dtos.CategoryDtos;
using Multishop.Catalog.Dtos.ProductDetailDtos;
using Multishop.Catalog.Dtos.ProductDtos;
using Multishop.Catalog.Dtos.ProductImageDtos;
using Multishop.Catalog.Entities;

namespace Multishop.Catalog.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping() 
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetByIdProductDto>().ReverseMap();

            CreateMap<ProductDetail, ResultProductDto>().ReverseMap();
            CreateMap<ProductDetail, CreateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, UpdateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, GetByIdProductDetailDto>().ReverseMap();

            CreateMap<ProductImages, ResultProductImageDto>().ReverseMap();
            CreateMap<ProductImages, CreateProductImageDto>().ReverseMap();
            CreateMap<ProductImages, UpdateProductImageDto>().ReverseMap();
            CreateMap<ProductImages, GetByIdProductImageDto>().ReverseMap();
        }
    }
}

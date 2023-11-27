using AutoMapper;
using HelperStockBeta.Application.DTOs;
using HelperStockBeta.Domain.Entities;

namespace HelperStockBeta.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile() 
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}

using AutoMapper;
using AutoMapperExample.DTOs;
using AutoMapperExample.Models;

namespace AutoMapperExample.Mapping;

public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateProductDto, Product>();
        CreateMap<UpdateProductDto, Product>();
    }
}

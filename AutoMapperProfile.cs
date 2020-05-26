using AutoMapper;
using NoLaTengo.Dtos;
using NoLaTengo.Models;

public class AutoMapperProfile : Profile
{

    public AutoMapperProfile()
    {
        CreateMap<Category, GetCategoryDto>();
        CreateMap<AddCategoryDto, Category>();
    }

}
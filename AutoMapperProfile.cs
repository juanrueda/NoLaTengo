using AutoMapper;
using NoLaTengo.Dtos;
using NoLaTengo.Models;

public class AutoMapperProfile : Profile
{

    public AutoMapperProfile()
    {
        CreateMap<Category, GetCategoryDto>();
        CreateMap<GetCategoryDto, Category>();
        CreateMap<AddCategoryDto, Category>();
        CreateMap<Book, GetBookDto>();
        CreateMap<AddBookDto, Book>();
    }

}
using AutoMapper;
using WebAPITutorial.Models;
using WebAPITutorial.Models.DTO;

namespace WebAPITutorial.Map;

public class MyMapper : Profile
{
    public MyMapper()
    {
        CreateMap<CategoryDTO, Category>();
        CreateMap<Category, CategoryDTO>();
    }
}

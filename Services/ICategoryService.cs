using System.Collections.Generic;
using System.Threading.Tasks;
using NoLaTengo.Dtos;
using NoLaTengo.Models;

namespace NoLaTengo.Services
{

    public interface ICategoryService
    {
        Task<ServiceResponse<List<GetCategoryDto>>> GetAllCategories();
        Task<ServiceResponse<GetCategoryDto>> GetCategoryById(int id);
        Task<ServiceResponse<List<GetCategoryDto>>> AddCategory(AddCategoryDto category);

    }
}
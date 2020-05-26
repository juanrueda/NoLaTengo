using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NoLaTengo.Data;
using NoLaTengo.Dtos;
using NoLaTengo.Models;

namespace NoLaTengo.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CategoryService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetCategoryDto>>> GetAllCategories()
        {
            ServiceResponse<List<GetCategoryDto>> response = new ServiceResponse<List<GetCategoryDto>>();

            List<Category> dbCategories = await _context.Categories.ToListAsync();

            response.Data = dbCategories.Select(c => _mapper.Map<GetCategoryDto>(c)).ToList();

            return response;
        }

        public async Task<ServiceResponse<GetCategoryDto>> GetCategoryById(int id)
        {
            ServiceResponse<GetCategoryDto> response = new ServiceResponse<GetCategoryDto>();

            Category dbCategory = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);

            response.Data = _mapper.Map<GetCategoryDto>(dbCategory);

            return response;
        }

        public async Task<ServiceResponse<List<GetCategoryDto>>> AddCategory(AddCategoryDto newCategory)
        {
            ServiceResponse<List<GetCategoryDto>> response = new ServiceResponse<List<GetCategoryDto>>();

            Category dbCategory = _mapper.Map<Category>(newCategory);

            await _context.Categories.AddAsync(dbCategory);
            await _context.SaveChangesAsync();

            response.Data = _context.Categories.Select(c => _mapper.Map<GetCategoryDto>(c)).ToList();

            return response;
        }
    }
}
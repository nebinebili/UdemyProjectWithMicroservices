using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Services.Catalog.Models;
using MicroserviceProjectShared.Dtos;

namespace FreeCourse.Services.Catalog.Services
{
    public interface ICategoryServices
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();

        Task<Response<CategoryDto>> GetByIdAsync(string id);

        Task<Response<CategoryDto>> CreateAsync(CategoryDto categoryDto);
    }
}

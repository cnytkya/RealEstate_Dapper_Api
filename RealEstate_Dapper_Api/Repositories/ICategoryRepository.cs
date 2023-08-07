using RealEstate_Dapper_Api.Dtos.CategoryDtos;

namespace RealEstate_Dapper_Api.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<ResaultCategoryDto>> GetAllCategoryAsync();
    }
}

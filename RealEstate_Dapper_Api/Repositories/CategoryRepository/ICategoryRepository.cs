using RealEstate_Dapper_Api.Dtos.CategoryDtos;

namespace RealEstate_Dapper_Api.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategoryAsync(CreateCategoryDto categoryDto);
        void DeleteCategoryAsync(int id);
        void UpdateCategoryAsync(UpdateCategoryDto categoryDto);
        Task<GetByIDCategoryDto> GetOneCategoryAsync(int id);
    }
}

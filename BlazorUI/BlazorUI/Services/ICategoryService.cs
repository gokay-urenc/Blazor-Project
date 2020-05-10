using BlazorUI.Models;
using System.Threading.Tasks;

namespace BlazorUI.Services
{
    public interface ICategoryService
    {
        Task<CategoryListViewModel[]> GetCategories();
        Task<CategoryViewModel> GetCategoryById(int categoryId);
        Task Add(CategoryViewModel categoryViewModel);
        Task Save(CategoryViewModel categoryViewModel);
    }
}
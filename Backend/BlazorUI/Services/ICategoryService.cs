using BlazorUI.Models;
using System.Threading.Tasks;

namespace BlazorUI.Services
{
    public interface ICategoryService
    {
        Task<CategoryListViewModel[]> GetCategories();
    }
}
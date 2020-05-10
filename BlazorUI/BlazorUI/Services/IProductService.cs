using BlazorUI.Models;
using System.Threading.Tasks;

namespace BlazorUI.Services
{
    public interface IProductService
    {
        Task<ProductListViewModel[]> GetProducts();
        Task<ProductViewModel> GetProductById(int productId);
        Task Add(ProductViewModel productViewModel);
        Task Save(ProductViewModel productViewModel);
    }
}
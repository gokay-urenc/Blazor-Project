using BlazorUI.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorUI.Services
{
    public class ProductService : IProductService
    {
        private HttpClient _httpClient;
        private readonly string baseUrl = "https://localhost:44395/";

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<ProductViewModel> GetProductById(int productId)
        {
            return _httpClient.GetJsonAsync<ProductViewModel>($"{baseUrl}api/products/getbyid?productid=" + productId);
        }

        public Task<ProductListViewModel[]> GetProducts()
        {
            return _httpClient.GetJsonAsync<ProductListViewModel[]>($"{baseUrl}api/products/getall");
        }

        public async Task Add(ProductViewModel productViewModel)
        {
            await _httpClient.PostJsonAsync($"{baseUrl}api/products/add", productViewModel);
        }
        
        public async Task Save(ProductViewModel productViewModel)
        {
            await _httpClient.PostJsonAsync($"{baseUrl}api/products/update", productViewModel);
        }
    }
}
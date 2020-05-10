using BlazorUI.URLs;
using BlazorUI.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorUI.Services
{
    public class ProductService : IProductService
    {
        private HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<ProductViewModel> GetProductById(int productId)
        {
            return _httpClient.GetJsonAsync<ProductViewModel>($"{Addresses.baseAPI}products/getbyid?productid=" + productId);
        }

        public Task<ProductListViewModel[]> GetProducts()
        {
            return _httpClient.GetJsonAsync<ProductListViewModel[]>($"{Addresses.baseAPI}products/getall");
        }

        public async Task Add(ProductViewModel productViewModel)
        {
            await _httpClient.PostJsonAsync($"{Addresses.baseAPI}products/add", productViewModel);
        }
        
        public async Task Save(ProductViewModel productViewModel)
        {
            await _httpClient.PostJsonAsync($"{Addresses.baseAPI}products/update", productViewModel);
        }
    }
}
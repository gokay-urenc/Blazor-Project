using BlazorUI.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorUI.Services
{
    public class CategoryService : ICategoryService
    {
        private HttpClient _httpClient;
        private readonly string baseUrl = "https://localhost:44395/";

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<CategoryListViewModel[]> GetCategories()
        {
            return _httpClient.GetJsonAsync<CategoryListViewModel[]>($"{baseUrl}api/categories/getall");
        }
    }
}
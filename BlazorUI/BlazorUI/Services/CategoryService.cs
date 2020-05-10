using BlazorUI.Models;
using BlazorUI.URLs;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorUI.Services
{
    public class CategoryService : ICategoryService
    {
        private HttpClient _httpClient;

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<CategoryViewModel> GetCategoryById(int categoryId)
        {
            return _httpClient.GetJsonAsync<CategoryViewModel>($"{Addresses.baseAPI}categories/getbyid?categoryid=" + categoryId);
        }

        public Task<CategoryListViewModel[]> GetCategories()
        {
            return _httpClient.GetJsonAsync<CategoryListViewModel[]>($"{Addresses.baseAPI}categories/getall");
        }

        public async Task Add(CategoryViewModel categoryViewModel)
        {
            await _httpClient.PostJsonAsync($"{Addresses.baseAPI}categories/add", categoryViewModel);
        }

        public async Task Save(CategoryViewModel categoryViewModel)
        {
            await _httpClient.PostJsonAsync($"{Addresses.baseAPI}categories/update", categoryViewModel);
        }
    }
}
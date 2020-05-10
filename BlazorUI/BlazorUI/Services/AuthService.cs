using Blazor.Extensions.Storage;
using BlazorUI.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BlazorUI.Services
{
    public class AuthService : IAuthService
    {
        private HttpClient _httpClient;
        private LocalStorage _localStorage;

        public bool IsLoggedIn { get; set; }

        public AuthService(HttpClient httpClient, LocalStorage localStorage)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
        }

        public async Task Login(LoginModel loginModel)
        {
            var response = await _httpClient.PostJsonAsync<TokenModel>("https://localhost:44395/api/auth/login", loginModel);
            if (!String.IsNullOrEmpty(response.Token))
            {
                await _localStorage.SetItem("token", response.Token);
                IsLoggedIn = true;
            }
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItem("token");
            IsLoggedIn = false;
        }

        private async Task SetAuthorization()
        {
            if (!_httpClient.DefaultRequestHeaders.Contains("Authorization"))
            {
                var token = await _localStorage.GetItem<string>("token");
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }
    }
}
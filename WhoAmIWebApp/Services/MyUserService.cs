using Microsoft.AspNetCore.Mvc;
using WhoAmIWebApp.Helpers;
using WhoAmIWebApp.Helpers.WeatherForecast.Web.Helpers;
using WhoAmIWebApp.Models;
using WhoAmIWebApp.Services.Interfaces;

namespace WhoAmIWebApp.Services
{
    public class MyUserService : IMyUserService
    {
        private readonly HttpClient _httpClient;

        public string basePath = "api/MyUser";

        public MyUserService (HttpClient httpClient)
        {
            _httpClient = httpClient;
            
        }
   
        public async Task<MyUser> Create(MyUser user)
        {
            
            var response = await _httpClient.PostAsJsonAsync(basePath, user);
            return await response.ReadContentAsync<MyUser>();
        }
    }
}

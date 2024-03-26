using BaseLibrary.DTOs;
using BaseLibrary.Responses;
using ClientLibrary.Helpers;
using ClientLibrary.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ClientLibrary.Services.Implementations
{
    public class UserAccountService(GetHttpClient getHttpClient) : IUserAccountService
    {
        public const string AuthUrl = "api/authentication";

  async Task<GeneralResponse> IUserAccountService.CreateAsync(Register user)
        {
            var httpClient = getHttpClient.GetPublicHttpClient();
            var result = await httpClient.PostAsJsonAsync($"{AuthUrl}/register", user);
            if (!result.IsSuccessStatusCode) return new GeneralResponse(false, "Error occured");

            return await result.Content.ReadFromJsonAsync<GeneralResponse>()!;
        }
  async Task<LoginResponse> IUserAccountService.SignInAsync(Register user)
        {
            var httpClient = getHttpClient.GetPublicHttpClient();
            var result = await httpClient.PostAsJsonAsync($"{AuthUrl}/login", user);
            if (!result.IsSuccessStatusCode) return new LoginResponse(false, "An error occured");

            return await result.Content.ReadFromJsonAsync<LoginResponse>();
        }
        Task<LoginResponse> IUserAccountService.RefreshTokenAsync(RefreshToken token)
        {
            throw new NotImplementedException();
        }


        Task<WeatherForecast[]> IUserAccountService.GetWeatherForecast()
        {
            throw new NotImplementedException();
        }
    }
}

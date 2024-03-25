using BaseLibrary.DTOs;
using BaseLibrary.Responses;
using ClientLibrary.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLibrary.Services.Implementations
{
    public class UserAccountService : IUserAccountService
    {
        Task<GeneralResponse> IUserAccountService.CreateAsync(Register user)
        {
            throw new NotImplementedException();
        }
        Task<LoginResponse> IUserAccountService.RefreshTokenAsync(RefreshToken token)
        {
            throw new NotImplementedException();
        }

        Task<LoginResponse> IUserAccountService.SignInAsync(Register user)
        {
            throw new NotImplementedException();
        }
        Task<WeatherForecast[]> IUserAccountService.GetWeatherForecast()
        {
            throw new NotImplementedException();
        }
    }
}

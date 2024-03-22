﻿using BaseLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Repositories.Contracts
{
    public class IUserAccount
    {
        Task<GeneralResponse> CreateAsync(Register user);

        Task<LoginResponse> SignInAsync(Login user);
    }
}

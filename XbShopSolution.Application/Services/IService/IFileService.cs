﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XbShopSolution.Application.Services.IService
{
    public interface IFileService
    {
        Task<string> SaveImage(IFormFile imageFile);
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace mobile.Services.Interfaces
{
    public interface IVehiclesImageService
    {
        string FormFileToBase64(IFormFile file);
    }
}

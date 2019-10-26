using Microsoft.AspNetCore.Http;
using mobile.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace mobile.Services
{
    public class VehicleImageService : IVehiclesImageService
    {
        public string FormFileToBase64(IFormFile file)
        {
            byte[] buffer = new byte[1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                //for (int i = 0; i < buffer.Length; i++)
                //{
                //    read = file.OpenReadStream().Read(buffer, 0, buffer.Length);
                //    ms.Write(buffer, 0, read);
                //}
                while ((read = file.OpenReadStream().Read(buffer, 0, buffer.Length)) > 0)
                {
                    read = file.OpenReadStream().Read(buffer, 0, buffer.Length);
                }
                ms.Write(buffer, 0, read);
                return Convert.ToBase64String(ms.ToArray());
            }
        }
    }
}

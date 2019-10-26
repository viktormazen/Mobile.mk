using mobile.Domain.Models;
using mobile.WebModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace mobile.Services.Interfaces
{
    public interface IVehicleService
    {
        
        IEnumerable<VehicleViewModel> GetAllVehicles();
        IEnumerable<VehicleViewModel> GetUserVehicles(string userName);
        VehicleViewModel GetVehicleById(int id);
        void CreateVehicle(VehicleCreateViewModel vehicle);
        void UpdateVehicle(VehicleViewModel vehicle);
        void RemoveVehicle(int id);
    }
}

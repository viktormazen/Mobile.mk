using AutoMapper;
using Microsoft.AspNetCore.Http;
using mobile.DataAccess.Interfaces;
using mobile.Domain.Models;
using mobile.Services.Interfaces;
using mobile.WebModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mobile.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Vehicle> _vehicleRepo;
        private readonly IRepository<VehicleImage> _vehicleImageRepo;
        private readonly IVehiclesImageService _vehiclesImageService;
        private readonly IUserService _userService;

        public VehicleService(
            IRepository<Vehicle> vehicleRepo,
            IRepository<VehicleImage> vehicleImageRepo,
            IMapper mapper, 
            IVehiclesImageService vehiclesImageService,
            IUserService userService)
        {
            _vehicleRepo = vehicleRepo;
            _vehicleImageRepo = vehicleImageRepo;
            _mapper = mapper;
            _vehiclesImageService = vehiclesImageService;
            _userService = userService;
        }

        public IEnumerable<VehicleViewModel> GetAllVehicles()
        {
            return _mapper.Map<IEnumerable<VehicleViewModel>>(_vehicleRepo.GetAll());
        }

        public IEnumerable<VehicleViewModel> GetUserVehicles(string userName)
        {
            UserViewModel currentUser = _userService.GetCurrentUser(userName);

            return _mapper.Map<IEnumerable<VehicleViewModel>>(
                _vehicleRepo.GetAll()
                    .Where(v => v.UserId == currentUser.Id)
            );
        }

        public VehicleViewModel GetVehicleById(int id)
        {
            Vehicle vehicle = _vehicleRepo.GetById(id);
            if (vehicle == null)
            {
                throw new Exception("Vehicle was not found :(");
            }
            return _mapper.Map<VehicleViewModel>(vehicle);
        }


        public void CreateVehicle(VehicleCreateViewModel vehicle)
        {
            _vehicleRepo.Insert(_mapper.Map<Vehicle>(vehicle));
            Vehicle currentVehicle = _vehicleRepo.GetAll().LastOrDefault();

            foreach (IFormFile vi in vehicle.Images)
            {
                _vehicleImageRepo.Insert(new VehicleImage
                {
                    VehicleId = currentVehicle.Id,
                    ImageString = _vehiclesImageService.FormFileToBase64(vi)
                });
            }
        }


        public void UpdateVehicle(VehicleViewModel vehicle)
        {
            _vehicleRepo.Update(_mapper.Map<Vehicle>(vehicle));
        }

        public void RemoveVehicle(int id)
        {
            _vehicleRepo.Delete(id);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using mobile.DataAccess.Interfaces;
using mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mobile.DataAccess.Repositories
{
    public class VehicleRepository : BaseRepository<mobileDbContext>, IRepository<Vehicle>
    {
        public VehicleRepository(mobileDbContext context) : base(context) { }


        public IEnumerable<Vehicle> GetAll()
        {
            return _db.Vehicles
                .Include(v => v.Images)
                .ToList();
        }

        public Vehicle GetById(int id)
        {
            return _db.Vehicles
                .Include(v => v.Images)
                .FirstOrDefault(v => v.Id == id);
        }

        public int Insert(Vehicle entity)
        {
            _db.Vehicles.Add(entity);
            return _db.SaveChanges();;
        }

        public int Update(Vehicle entity)
        {
            Vehicle vehicle = _db.Vehicles.FirstOrDefault(v => v.Id == entity.Id);
            if(vehicle == null)
            {
                return -1;
            }

           
            vehicle.Make = entity.Make;
            vehicle.Model = entity.Model;
            vehicle.Category = entity.Category;
            vehicle.Year = entity.Year;
            vehicle.Fueltype = entity.Fueltype;
            vehicle.CubicCapacity = entity.CubicCapacity;
            vehicle.Power = entity.Power;
            vehicle.GearBox = entity.GearBox;
            vehicle.Mileage = entity.Mileage;
            vehicle.Price = entity.Price;
            vehicle.Location = entity.Location;
            vehicle.VehicleDescription = entity.VehicleDescription;

            return _db.SaveChanges();
            
        }

        public int Delete(int id)
        {
            Vehicle vehicle = _db.Vehicles.FirstOrDefault(v => v.Id == id);
            if(vehicle == null)
            {
                return -1;
            }
            _db.Vehicles.Remove(vehicle);
            return _db.SaveChanges();
        }

    }
}

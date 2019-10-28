using Microsoft.AspNetCore.Http;
using mobile.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace mobile.WebModels
{
    public class VehicleViewModel
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public Category Category { get; set; }
        public string Year { get; set; }
        public Fueltype Fueltype { get; set; }
        public string CubicCapacity { get; set; }
        public string Power { get; set; }
        public GearBox GearBox { get; set; }
        public int Mileage { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }
        public string VehicleDescription { get; set; }
        public IEnumerable<VehicleImageViewModel> Images { get; set; }
    }
}

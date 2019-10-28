using mobile.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace mobile.Domain.Models
{
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public Category Category { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public Fueltype Fueltype { get; set; }
        [Required]
        public string CubicCapacity { get; set; }
        [Required]
        public string Power { get; set; }
        public GearBox GearBox { get; set; }
        public int Mileage { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Location { get; set; }
        public string VehicleDescription { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public virtual IEnumerable<VehicleImage> Images { get; set; }

        //public string PhotoPath { get; set; }
    }
}

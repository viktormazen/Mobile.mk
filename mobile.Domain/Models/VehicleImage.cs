using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace mobile.Domain.Models
{
    public class VehicleImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        [Required]
        public string ImageString { get; set; }
    }
}

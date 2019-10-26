using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace mobile.WebModels
{
    public class VehicleImageViewModel
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string Image { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace mobile.Domain.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public virtual IEnumerable<Vehicle> Vehicles { get; set; }
    }
}

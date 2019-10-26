using mobile.DataAccess.Interfaces;
using mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mobile.DataAccess.Repositories
{
    public class VehicleImageRepository : BaseRepository<mobileDbContext>, IRepository<VehicleImage>
    {
        public VehicleImageRepository(mobileDbContext context) : base(context) { }

        public IEnumerable<VehicleImage> GetAll()
        {
            return _db.VehicleImages.ToList();
        }

        public VehicleImage GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(VehicleImage entity)
        {
            _db.VehicleImages.Add(entity);
            return _db.SaveChanges();
        }

        public int Update(VehicleImage entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

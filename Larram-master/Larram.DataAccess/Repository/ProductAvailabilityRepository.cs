﻿using Larram.DataAccess.Data;
using Larram.DataAccess.Repository.IRepository;
using Larram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larram.DataAccess.Repository
{
    public class ProductAvailabilityRepository : Repository<ProductAvailability>, IProductAvailabilityRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductAvailabilityRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ProductAvailability productAvailability)
        {
            var objFromDb = _db.ProductAvailabilities.FirstOrDefault(s => s.Id == productAvailability.Id);
            if(objFromDb != null)
            {
                objFromDb.ProductId = productAvailability.ProductId;
                objFromDb.SizeId = productAvailability.SizeId;
                objFromDb.Quantity = productAvailability.Quantity;
                _db.SaveChanges();
            }
        }
    }
}

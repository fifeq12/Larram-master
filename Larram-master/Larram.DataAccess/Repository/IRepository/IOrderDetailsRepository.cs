﻿using Larram.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Larram.DataAccess.Repository.IRepository
{
    public interface IOrderDetailsRepository : IRepository<OrderDetails>
    {
        void Update(OrderDetails orderDetails);
    }
}

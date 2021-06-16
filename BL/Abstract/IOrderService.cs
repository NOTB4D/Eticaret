﻿using Core.Utilities.Results;
using EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstract
{
   public interface IOrderService
    {
        IDataResult<Order> Add(Order order);
        IResult Update(Order order);
    }
}

﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.Concrete
{
   public class BasketProduct:IEntity
    {
        public int BasketProductId { get; set; }

        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
    }
}

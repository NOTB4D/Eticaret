﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.DTOs
{
   public  class ProductSubCategoryDto:IDto
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}

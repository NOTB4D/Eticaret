﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.Concrete
{
   public  class City: IEntity
    {
        public int id { get; set; }
        public string city_name { get; set; }

    }
}

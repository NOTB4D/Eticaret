﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.Concrete
{
    public class CarouselImage : IEntity
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }

    }
}
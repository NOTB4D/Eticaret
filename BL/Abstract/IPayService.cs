﻿using Core.Utilities.Results;
using EL.Concrete;
using Iyzipay.Model;
using Iyzipay.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstract
{
   public interface IPayService
    {
        IResult PayWithIyzico(IyzicoModel ıyzicoModel);
    }
}

﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstract
{
    public  interface IUserOperationClaimService
    {
        IResult AddUserClaim(User user);
    }
}

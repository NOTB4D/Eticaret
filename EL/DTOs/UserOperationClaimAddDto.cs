﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.DTOs
{
    public class UserOperationClaimAddDto : IDto
    {
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // Temel Voidler için Başlangıç
    public interface IResult
    {
        bool Success { get; }
        string Messages { get; }

    }
}

﻿using DailyPlanner.Domain.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner.Domain.Interfaces.Validations
{
    public interface IBaseValidator<in T> where T : class
    {
        BaseResult ValidateOnNull(T model);
    }
}

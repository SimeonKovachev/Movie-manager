﻿
using Store1.Models;
using Store1.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Store1.Data.Services
{
    public interface IActorsService : IEntityBaseRepository<Actor>
    {
    }
}


using Microsoft.EntityFrameworkCore;
using Store1.Data.Base;
using Store1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Store1.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
     
        public ActorsService(StoreDbContext context) : base(context) { }
        

      
    }
}

using Store1.Data.Base;
using Store1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Store1.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService

    {
        public CinemasService(StoreDbContext context) : base(context)
        {
        }
    }
}

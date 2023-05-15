using Store1.Data.Base;
using Store1.Models;

namespace Store1.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        
        public ProducersService(StoreDbContext context) : base(context) { }
    }
}

using BuldringNo.Entities;

namespace BuldringNo.Infrastructure.Repositories
{
    public class AreaRepository : EntityBaseRepository<Area>, IAreaRepository
    {
        public AreaRepository(BuldringNoContext context)
            : base(context)
        { }
    }
}

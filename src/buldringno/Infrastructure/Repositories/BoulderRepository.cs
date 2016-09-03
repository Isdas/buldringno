using BuldringNo.Entities;

namespace BuldringNo.Infrastructure.Repositories
{
    public class BoulderRepository : EntityBaseRepository<Boulder>, IBoulderRepository
    {
        public BoulderRepository(BuldringNoContext context)
            : base(context)
        { }
    }
}

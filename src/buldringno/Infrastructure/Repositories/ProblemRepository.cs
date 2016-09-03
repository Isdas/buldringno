using BuldringNo.Entities;

namespace BuldringNo.Infrastructure.Repositories
{
    public class ProblemRepository : EntityBaseRepository<Problem>, IProblemRepository
    {
        public ProblemRepository(BuldringNoContext context)
            : base(context)
        { }
    }
}

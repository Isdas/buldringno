using BuldringNo.Entities;

namespace BuldringNo.Infrastructure.Repositories
{
    public class RoleRepository : EntityBaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(BuldringNoContext context)
            : base(context)
        { }
    }
}

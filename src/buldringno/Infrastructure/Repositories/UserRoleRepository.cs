using BuldringNo.Entities;

namespace BuldringNo.Infrastructure.Repositories
{
    public class UserRoleRepository : EntityBaseRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(BuldringNoContext context)
            : base(context)
        { }
    }
}

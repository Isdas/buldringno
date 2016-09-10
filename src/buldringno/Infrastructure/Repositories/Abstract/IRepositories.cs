using BuldringNo.Entities;
using System.Collections.Generic;

namespace BuldringNo.Infrastructure.Repositories
{
    public interface IAreaRepository : IEntityBaseRepository<Area> { }

    public interface IBoulderRepository : IEntityBaseRepository<Boulder> { }

    public interface ILoggingRepository : IEntityBaseRepository<Error> { }

    public interface IProblemRepository : IEntityBaseRepository<Problem> { }

    public interface IRoleRepository : IEntityBaseRepository<Role> { }

    public interface IUserRepository : IEntityBaseRepository<User>
    {
        User GetSingleByUsername(string username);
        IEnumerable<Role> GetUserRoles(string username);
    }

    public interface IUserRoleRepository : IEntityBaseRepository<UserRole> { }
}

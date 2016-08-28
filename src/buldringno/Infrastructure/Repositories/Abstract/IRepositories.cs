﻿using buldringno.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buldringno.Infrastructure.Repositories
{
    public interface IAlbumRepository : IEntityBaseRepository<Album> { }

    public interface ILoggingRepository : IEntityBaseRepository<Error> { }

    public interface IPhotoRepository : IEntityBaseRepository<Photo> { }

    public interface IRoleRepository : IEntityBaseRepository<Role> { }

    public interface IUserRepository : IEntityBaseRepository<User>
    {
        User GetSingleByUsername(string username);
        IEnumerable<Role> GetUserRoles(string username);
    }

    public interface IUserRoleRepository : IEntityBaseRepository<UserRole> { }
}

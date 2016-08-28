using buldringno.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buldringno.Infrastructure.Repositories
{
    public class UserRoleRepository : EntityBaseRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(PhotoGalleryContext context)
            : base(context)
        { }
    }
}

using buldringno.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buldringno.Infrastructure.Repositories
{
    public class RoleRepository : EntityBaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(PhotoGalleryContext context)
            : base(context)
        { }
    }
}

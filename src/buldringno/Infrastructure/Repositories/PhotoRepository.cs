using buldringno.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buldringno.Infrastructure.Repositories
{
    public class PhotoRepository : EntityBaseRepository<Photo>, IPhotoRepository
    {
        public PhotoRepository(PhotoGalleryContext context)
            : base(context)
        { }
    }
}

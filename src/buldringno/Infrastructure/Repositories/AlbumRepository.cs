using buldringno.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buldringno.Infrastructure.Repositories
{
    public class AlbumRepository : EntityBaseRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(PhotoGalleryContext context)
            : base(context)
        { }
    }
}

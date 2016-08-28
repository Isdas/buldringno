using BuldringNo.Entities;

namespace BuldringNo.Infrastructure.Repositories
{
    public class AlbumRepository : EntityBaseRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(BuldringNoContext context)
            : base(context)
        { }
    }
}

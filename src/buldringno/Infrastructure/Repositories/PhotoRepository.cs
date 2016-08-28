using BuldringNo.Entities;

namespace BuldringNo.Infrastructure.Repositories
{
    public class PhotoRepository : EntityBaseRepository<Photo>, IPhotoRepository
    {
        public PhotoRepository(BuldringNoContext context)
            : base(context)
        { }
    }
}

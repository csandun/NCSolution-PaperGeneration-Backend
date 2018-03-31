using NCS.PaperGeneration.Entities.Entities;
using NCS.PapperGeneration.DataService.Common;
using NCS.PaperGeneration.IDataServices;

namespace NCS.PaperGeneration.DataServices
{
    public class SectionRepository : GenericRepository<Section>, ISectionRepository
    {
        private readonly PaperGenerationDbContext _context;

        public SectionRepository(PaperGenerationDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}

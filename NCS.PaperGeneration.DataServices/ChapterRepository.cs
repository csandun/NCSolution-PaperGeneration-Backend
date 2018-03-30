using NCS.PaperGeneration.IDataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCS.PaperGeneration.Entities.Entities;
using NCS.PapperGeneration.DataService.Common;

namespace NCS.PaperGeneration.DataServices
{
    public class ChapterRepository : GenericRepository<Chapter>, IChapterRepository
    {
        private readonly PaperGenerationDbContext _context;

        public ChapterRepository(PaperGenerationDbContext context)
            : base(context)
        {
            _context = context;
        }
        
    }
}

using NCS.PaperGeneration.Entities.Entities;
using NCS.PaperGeneration.IDataServices;
using NCS.PapperGeneration.DataService.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.DataServices
{
    public class AlgorithmRepository : GenericRepository<Algorithms>, IAlgorithmRepository
    {
        private readonly PaperGenerationDbContext _context;

        public AlgorithmRepository(PaperGenerationDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}

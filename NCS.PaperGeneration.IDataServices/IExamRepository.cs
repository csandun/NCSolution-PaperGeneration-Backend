using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.IDataServices
{
    using NCS.PaperGeneration.Entities.Entities;
    using NCS.PapperGeneration.DataService.Common;

    public interface IExamRepository : IGenericRepository<Exam>
    {        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCS.PaperGeneration.BussinessService.Common;
using NCS.PaperGeneration.Entities.Entities;

namespace NCS.PaperGeneration.IServices
{
    public interface IExamService : IEntityService<Exam>
    {
        Exam GetById(int id);
    }
}

using NCS.PaperGeneration.Entities.Entities;
using NCS.PapperGeneration.DataService.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCS.PaperGeneration.Entities.CompactEntities;


namespace NCS.PaperGeneration.IDataServices
{
    public interface IUserExamAttemptQuestionRepository : IGenericRepository<UserExamAttemptQuestion>
    {
        List<UserExamAttemptQuestion> GetUserExamQuestions(int id);        
    }
}

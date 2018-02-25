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
    public class UserExamAttemptRepository : GenericRepository<UserExamAttempt>, IUserExamAttemptRepository
    {
        public UserExamAttemptRepository(PaperGenerationDbContext context) : base(context)
        {
        }
    }
}

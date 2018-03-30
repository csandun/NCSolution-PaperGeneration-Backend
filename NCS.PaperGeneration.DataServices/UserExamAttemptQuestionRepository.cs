using NCS.PaperGeneration.Entities.Entities;
using NCS.PaperGeneration.IDataServices;
using NCS.PapperGeneration.DataService.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCS.PaperGeneration.Entities.CompactEntities;


namespace NCS.PaperGeneration.DataServices
{
    public class UserExamAttemptQuestionRepository : GenericRepository<UserExamAttemptQuestion>, IUserExamAttemptQuestionRepository
    {
        private readonly PaperGenerationDbContext _context;        

        public UserExamAttemptQuestionRepository(PaperGenerationDbContext context)
            : base(context)
        {
            _context = context;
        }

        public List<UserExamAttemptQuestion> GetUserExamQuestions(int id)
        {
            var questions = _dbSet.Where(o => o.UserExamId == id).ToList<UserExamAttemptQuestion>();
            return questions;
        }

        public void SaveUserAnswer(int examId, int questionId, int answer)
        {
            var ss = _dbSet.Where(o => o.UserExamId == examId && o.QuestionId == examId).FirstOrDefault();
            ss.ChoiceId = answer;
            Update(ss);
        }
    }
}

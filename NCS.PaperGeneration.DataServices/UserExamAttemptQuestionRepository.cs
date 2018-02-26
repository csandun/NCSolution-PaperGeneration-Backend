using NCS.PaperGeneration.Entities.Entities;
using NCS.PaperGeneration.IDataServices;
using NCS.PapperGeneration.DataService.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // var a = _context.Questions.Select(o => o);

            //var examQuestions = _dbSet.Join(_context.Questions,
            //                    userExam => userExam.QuestionId,
            //                    question => question.Id,
            //                    (userExam, question) =>
            //                    new { UserExamAttemptQuestion = userExam, Question = question })
            //                    .Where(o => o.UserExamAttemptQuestion.Id == id);


            var questions = _dbSet.Where(o => o.UserExamId == id).ToList<UserExamAttemptQuestion>();



            //var examQuestions = _dbSet.Where(o => o.UserExamId == id).ToList<UserExamAttemptQuestion>();
            //examQuestions.Select(x =>
            //{
            //    x.Question = _context.Questions.FirstOrDefault(q => q.Id == x.QuestionId);
            //    return x;
            //});

            return questions;
        }
    }
}

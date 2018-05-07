using NCS.PaperGeneration.BussinessService.Common;
using NCS.PaperGeneration.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCS.PaperGeneration.Entities.CompactEntities;

namespace NCS.PaperGeneration.IServices
{
    public interface IUserExamQuestionService
    {
        List<UserExamAttemptQuestion> GetUserExamQuestions(int userExamId);
        void SaveUserAnswer(int examId, int questionId, int answer);
    }
}

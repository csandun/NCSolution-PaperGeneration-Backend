using NCS.PaperGeneration.BussinessService.Common;
using NCS.PaperGeneration.Entities.Entities;
using NCS.PaperGeneration.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCS.PapperGeneration.DataService.Common;
using NCS.PaperGeneration.IDataServices;
using NCS.PaperGeneration.Entities.CompactEntities;

namespace NCS.PaperGeneration.Services
{
    public class UserExamQuestionService : EntityService<UserExamAttemptQuestion>, IUserExamQuestionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserExamAttemptQuestionRepository _userExamAttemptQuestionRepository;
        public UserExamQuestionService(IUnitOfWork unitOfWork, IUserExamAttemptQuestionRepository userExamAttemptQuestionRepository) 
            : base(unitOfWork, userExamAttemptQuestionRepository)
        {
            this._unitOfWork = unitOfWork;
            this._userExamAttemptQuestionRepository = userExamAttemptQuestionRepository;
        }

        public List<UserExamAttemptQuestion> GetUserExamQuestions(int userExamId)
        {
            return _userExamAttemptQuestionRepository.GetUserExamQuestions(userExamId);
        }

      
    }
}

using NCS.PaperGeneration.BussinessService.Common;
using NCS.PaperGeneration.Entities.Entities;
using NCS.PaperGeneration.IDataServices;
using NCS.PaperGeneration.IServices;
using NCS.PapperGeneration.DataService.Common;
using System.Collections.Generic;

namespace NCS.PaperGeneration.Services
{
    public class UserExamService : EntityService<UserExamAttempt>, IUserExamService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserExamAttemptRepository _userExamRepository;
        private readonly IUserExamAttemptQuestionRepository _userExamAttemptQuestionRepository;
        public UserExamService(IUnitOfWork unitOfWork, 
            IUserExamAttemptRepository userExamRepository,
            IUserExamAttemptQuestionRepository userExamAttemptQuestionRepository) 
            : base(unitOfWork, userExamRepository)
        {
            _unitOfWork = unitOfWork;
            _userExamRepository = userExamRepository;
            _userExamAttemptQuestionRepository = userExamAttemptQuestionRepository;
        }

        public List<UserExamAttemptQuestion> GetUserExamQuestions(int userExamId)
        {
            return _userExamAttemptQuestionRepository.GetUserExamQuestions(userExamId);
        }
    }
}

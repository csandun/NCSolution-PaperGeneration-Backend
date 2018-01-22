using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCS.PaperGeneration.BussinessService.Common;
using NCS.PaperGeneration.Entities.Entities;
using NCS.PaperGeneration.IDataServices;
using NCS.PaperGeneration.IServices;
using NCS.PapperGeneration.DataService.Common;

namespace NCS.PaperGeneration.Services
{
    public class ExamService : EntityService<Exam>, IExamService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IExamRepository _examRepository;
        public ExamService(IUnitOfWork unitOfWork, IExamRepository examRepository) : base(unitOfWork, examRepository)
        {
            _examRepository = examRepository;
            _unitOfWork = unitOfWork;
        }

        public Exam GetById(int id)
        {
            return _examRepository.GetById(id);
        }
    }
}

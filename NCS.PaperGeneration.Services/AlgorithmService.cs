using NCS.PaperGeneration.BussinessService.Common;
using NCS.PaperGeneration.Entities.Entities;
using NCS.PaperGeneration.IDataServices;
using NCS.PaperGeneration.IServices;
using NCS.PapperGeneration.DataService.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.Services
{
    public class AlgorithmService : EntityService<Algorithms>, IAlgorithmService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAlgorithmRepository _algorithmRepository;

        public AlgorithmService(IUnitOfWork unitOfWork, IAlgorithmRepository repository) : base(unitOfWork, repository)
        {
            this._unitOfWork = unitOfWork;
            this._algorithmRepository = repository;
        }
    }
}

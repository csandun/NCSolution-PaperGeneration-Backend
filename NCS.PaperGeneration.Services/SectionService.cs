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

namespace NCS.PaperGeneration.Services
{
    public class SectionService : EntityService<Section>, IServices.ISectionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDataServices.ISectionService _sectionRepository;
        public SectionService(IUnitOfWork unitOfWork, IDataServices.ISectionService repository) : base(unitOfWork, repository)
        {
            this._unitOfWork = unitOfWork;
            this._sectionRepository = repository;
        }
    }
}

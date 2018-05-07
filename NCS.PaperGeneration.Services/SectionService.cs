using NCS.PaperGeneration.BussinessService.Common;
using NCS.PaperGeneration.Entities.Entities;
using NCS.PapperGeneration.DataService.Common;
using NCS.PaperGeneration.IDataServices;

namespace NCS.PaperGeneration.Services
{
    using NCS.PaperGeneration.IServices;
    public class SectionService : EntityService<Section>, ISectionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISectionRepository _sectionRepository;
        public SectionService(IUnitOfWork unitOfWork, ISectionRepository repository) : base(unitOfWork, repository)
        {
            this._unitOfWork = unitOfWork;
            this._sectionRepository = repository;
        }
    }
}

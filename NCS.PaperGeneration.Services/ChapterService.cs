using NCS.PaperGeneration.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCS.PaperGeneration.Entities.Entities;
using NCS.PaperGeneration.BussinessService.Common;
using NCS.PapperGeneration.DataService.Common;
using NCS.PaperGeneration.IDataServices;

namespace NCS.PaperGeneration.Services
{
    public class ChapterService : EntityService<Chapter>, IChapterService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IChapterRepository _chapterRepository;
        public ChapterService(IUnitOfWork unitOfWork, IChapterRepository chapterRepository) 
            : base(unitOfWork, chapterRepository)
        {
            this._unitOfWork = unitOfWork;
            this._chapterRepository = chapterRepository;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.BussinessService.Common
{
    using NCS.PaperGeneration.Entities.CommonEntities;
    using NCS.PapperGeneration.DataService.Common;

    public abstract class EntityService<T> : IEntityService<T> where T : BaseEntity
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<T> _repository;

        public EntityService(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }


        public virtual void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _repository.Insert(entity);
            _unitOfWork.Save();
        }

        public virtual void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _repository.Update(entity);
            _unitOfWork.Save();
        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _repository.Delete(entity);
            _unitOfWork.Save();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}

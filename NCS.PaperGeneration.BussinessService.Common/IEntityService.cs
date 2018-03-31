using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.BussinessService.Common
{
    using NCS.PaperGeneration.Entities.CommonEntities;

    public interface IEntityService<T> : IService
    {
        void Create(T entity);
        void Delete(T entity);
        T Update(T entity);
        T GetById(int id);

        List<T> Get();
    }
}

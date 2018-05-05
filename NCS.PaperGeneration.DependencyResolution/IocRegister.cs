using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCS.PaperGeneration.BussinessService.Common;
using NCS.PaperGeneration.DataServices;
using NCS.PaperGeneration.IDataServices;
using NCS.PaperGeneration.IServices;
using NCS.PaperGeneration.Services;
using NCS.PapperGeneration.DataService.Common;
using Unity;

namespace NCS.PaperGeneration.DependencyResolution
{
    public class IocRegister
    {
        public static void RegisterAll(IUnityContainer container)
        {            
            RegisterDataServices(container);
            RegisterServices(container);
        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType(typeof(IEntityService<>), typeof(EntityService<>));
            container.RegisterType(typeof(IService), typeof(IEntityService<>));
            container.RegisterType(typeof(IExamService), typeof(ExamService));
            container.RegisterType(typeof(IUserExamService), typeof(UserExamService));            
            container.RegisterType(typeof(IUserExamQuestionService), typeof(UserExamQuestionService));            
            container.RegisterType(typeof(IChapterService), typeof(ChapterService));
            container.RegisterType(typeof(ISectionService), typeof(SectionService));
            container.RegisterType(typeof(IAlgorithmService), typeof(AlgorithmService));
            container.RegisterType(typeof(IUserService), typeof(UserService));
        }

        private static void RegisterDataServices(IUnityContainer container)
        {
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<DbContext, PaperGenerationDbContext>();
            container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            container.RegisterType(typeof(IExamRepository), typeof(ExamRepository));
            container.RegisterType(typeof(IUserExamAttemptRepository), typeof(UserExamAttemptRepository));
            container.RegisterType(typeof(IUserExamAttemptQuestionRepository), typeof(UserExamAttemptQuestionRepository));
            container.RegisterType(typeof(IChapterRepository), typeof(ChapterRepository));
            container.RegisterType(typeof(ISectionRepository), typeof(SectionRepository));
            container.RegisterType(typeof(IAlgorithmRepository), typeof(AlgorithmRepository));
            container.RegisterType(typeof(IUserRepository), typeof(UserRepository));
        }
    }
}

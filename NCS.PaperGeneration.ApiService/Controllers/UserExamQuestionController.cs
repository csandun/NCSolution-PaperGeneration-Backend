
using System.Web.Http;

namespace NCS.PaperGeneration.ApiService.Controllers
{
    [RoutePrefix("api/UserExamQuestions")]
    /// <summary>
    /// user exam attempt question controller
    /// </summary>
    public class UserExamQuestionController : ApiController
    {
        [Route("UserExam/{userExamId}/Questions")]
        public void GetUserExamQuestions(int userExamId)
        {

          
        }
    }
}

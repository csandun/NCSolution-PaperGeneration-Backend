// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserController.cs" company="NCSolution">
//   Copyright 2018
// </copyright>
// <summary>
//   Define User Service
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace NCS.PaperGeneration.ApiService.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text;
    using System.Web;
    using System.Web.Http;

    using NCS.PaperGeneration.Entities.Entities;
    using NCS.PaperGeneration.IServices;

    /// <summary>
    /// Define User Repository
    /// </summary>
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        /// <summary>
        /// Define user service
        /// </summary>
        private readonly IUserService userService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class. 
        /// </summary>
        /// <param name="userService">
        /// The user Service.
        /// </param>
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        /// <summary>
        /// Add user
        /// </summary>
        /// <param name="user">user object</param>
        [HttpPost]
        public void AddUser(LoginUser user)
        {
            try
            {
                this.userService.Create(user);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// update user
        /// </summary>
        /// <param name="user"> user object</param>
        [HttpPut]
        public void UpdateUser(LoginUser user)
        {
            try
            {
                this.userService.Update(user);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// get users list
        /// </summary>
        /// <returns>list of users</returns>
        [HttpGet]
        public List<LoginUser> GetUserList()
        {
            try
            {
                return this.userService.Get();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// get user by id
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns>user object</returns>
        [HttpGet]
        public LoginUser GetLoginUser(int id)
        {
            try
            {
                return this.userService.GetById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// login user
        /// </summary>
        /// <param name="user">user object</param>
        /// <returns>http response</returns>
        [HttpPost]
        [Route("Login")]
        public async System.Threading.Tasks.Task<HttpResponseMessage> LoginAsync(LoginUser user)
        {
            try
            {
                LoginUser loginUser = this.userService.ValideUser(user);

                if (loginUser != null)
                {
                    var request = HttpContext.Current.Request;
                    var tokenServiceUrl = request.Url.GetLeftPart(UriPartial.Authority) + request.ApplicationPath + "/token";
                    using (var client = new HttpClient())
                    {
                        var requestParams = new List<KeyValuePair<string, string>>
                        {
                            new KeyValuePair<string, string>("grant_type", "password"),
                            new KeyValuePair<string, string>("username", user.LoginUserName),
                            new KeyValuePair<string, string>("password", user.Password)
                        };
                        var requestParamsFormUrlEncoded = new FormUrlEncodedContent(requestParams);
                        var tokenServiceResponse = await client.PostAsync(tokenServiceUrl, requestParamsFormUrlEncoded);
                        var responseString = await tokenServiceResponse.Content.ReadAsStringAsync();
                        var responseCode = tokenServiceResponse.StatusCode;
                        var responseMsg = new HttpResponseMessage(responseCode)
                        {
                            Content = new StringContent(responseString, Encoding.UTF8, "application/json")
                        };
                        return responseMsg;
                    }
                }

                return new HttpResponseMessage();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

// <copyright file="UsersController.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.WebAPI.Controller
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using BusinessLogic.Exceptions;
    using BusinessLogic.Services;
    using Models;

    /// <summary>
    /// The controller for the users related request
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsersController : ApiController
    {
        /// <summary>
        /// Get the UserID for the specified by his email
        /// </summary>
        /// <param name="email">This email of the user</param>
        /// <returns> The UserID for the given email</returns>
        public HttpResponseMessage Get(string email)
        {
            try
            {
                var serviceAccount = ServiceAccount.GetInstance();
                var userId = serviceAccount.GetUserIdByEmail(email);
                return Request.CreateResponse(HttpStatusCode.OK, userId);
            }
            catch (NullUserException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "The user is not registered ");
            }
        }
    }
}
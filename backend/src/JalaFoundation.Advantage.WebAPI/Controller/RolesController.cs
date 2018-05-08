// <copyright file="RolesController.cs" company="Jala Foundation">
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
    /// The controller for the roles related request
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class RolesController : ApiController
    {
        /// <summary>
        /// Get the role for the specified email and password
        /// </summary>
        /// <param name="user">
        /// The object that contains the email and password
        /// </param>
        /// <returns>The Role for the given email and password</returns>
        public HttpResponseMessage Post(User user)
        {
            try
            {
                var serviceAccount = ServiceAccount.GetInstance();
                Role role = serviceAccount.GetRole(user.Email, user.Password);
                return Request.CreateResponse(HttpStatusCode.OK, role);
            }
            catch (NullRoleException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "The user is not registered ");
            }
        }
    }
}
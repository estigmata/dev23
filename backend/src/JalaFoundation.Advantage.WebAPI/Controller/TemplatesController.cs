// <copyright file="TemplatesController.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.WebAPI.Controller
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using JalaFoundation.Advantage.BusinessLogic.Exceptions;
    using JalaFoundation.Advantage.BusinessLogic.Services;

    /// <summary>
    /// The controller for the templates related request
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TemplatesController : ApiController
    {
        /// <summary>
        /// Get the list of all templates with its respective schedules
        /// </summary>
        /// <returns>
        /// A HttpResponseMessage with status code 200 if the list has items
        /// A HttpResponseMessage with status code 404 if the list is empty
        /// </returns>
        [HttpGet]
        [Route("api/v1/schedules/templates")]
        public HttpResponseMessage Get()
        {
            try
            {
                var templateService = SingletonBase<ServiceTemplate>.GetInstance();
                var templates = templateService.GetTemplatesList();

                return Request.CreateResponse(HttpStatusCode.OK, templates);
            }
            catch (EmptyTemplatesListException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
            }
        }
    }
}

// <copyright file="FormsController.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.WebAPI.Controller
{
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using JalaFoundation.Advantage.BusinessLogic.Exceptions;
    using JalaFoundation.Advantage.BusinessLogic.Services;

    /// <summary>
    /// This class is controller of Forms
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FormsController : ApiController
    {
        /// <summary>
        /// This Methods return a model form by id
        /// </summary>
        /// <param name="id"> This is id of the form </param>
        /// <returns>Return a model form</returns>
        public HttpResponseMessage GetFormById(int id)
        {
            try
            {
                var formService = SingletonBase<ServiceForm>.GetInstance();
                var form = formService.GetFormModelById(id);
                return Request.CreateResponse(HttpStatusCode.OK, form);
            }
            catch (NullFormException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
            }
        }

        /// <summary>
        /// This Methods return a list of forms, each form contains an id and name
        /// </summary>
        /// <returns>Return a list of forms</returns>
        public HttpResponseMessage GetForms()
        {
            try
            {
                var formService = SingletonBase<ServiceForm>.GetInstance();
                var forms = formService.GetFormsList().Select(form => new { id = form.Id, name = form.Name });

                return Request.CreateResponse(HttpStatusCode.OK, forms);
            }
            catch (NullListFormException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
            }
        }
    }
}
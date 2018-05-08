// <copyright file="CategoriesController.cs" company="Jala Foundation">
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
    /// This class is controller of Category
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CategoriesController : ApiController
    {
        /// <summary>
        /// This Methods return a list of categories, according to the value received
        /// </summary>
        /// <param name="field">this values is a identifier to specify what information should be returned</param>
        /// <returns>Return a list of categories</returns>
        [HttpGet]
        [Route("api/v1/categories")]
        public HttpResponseMessage GetCategories(string field = "")
        {
            try
            {
                var categoryService = SingletonBase<ServiceCategory>.GetInstance();
                
                if (field == "Name")
                {
                    var categories = categoryService.GetCategoriesList();

                    return Request.CreateResponse(HttpStatusCode.OK, categories);
                }

                if (field == string.Empty)
                {
                    var categoriesDetail = categoryService.GetCategoryListDetail();

                    return Request.CreateResponse(HttpStatusCode.OK, categoriesDetail);
                }
                
                return Request.CreateResponse(HttpStatusCode.NotAcceptable, "invalid parameter");
            }
            catch (NullListCategoryException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
            }
        }
    }
}
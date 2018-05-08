// <copyright file="TagsController.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.WebAPI.Controller
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using JalaFoundation.Advantage.BusinessLogic.Exceptions;
    using JalaFoundation.Advantage.BusinessLogic.Services;

    /// <summary>
    /// This class is controller of Tag
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class TagsController : ApiController
    {
        /// <summary>
        /// This Methods return a list of tags, each tag contains an id and name
        /// </summary>
        /// <returns>Return a list of tags</returns>
        /// [HttpGet]
        [Route("api/v1/tags")]
        public HttpResponseMessage GetTags()
        {
            try
            {
                var tagService = SingletonBase<ServiceTag>.GetInstance();
                var tags = tagService.GetTagsList();

                return Request.CreateResponse(HttpStatusCode.OK, tags);
            }
            catch (NullListTagsException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
            }
        }

        /// <summary>
        /// This Method delete the tags from a specific promoter
        /// </summary>
        /// <param name="promoterId">
        /// The promoterId is the id of a specific Promoter
        /// </param>
        /// <returns>
        /// Return a bool
        /// </returns>
        [HttpDelete]
        [Route("api/v1/tags/{promoterId:int}")]
        public HttpResponseMessage DeleteTags(int promoterId)
        {
            try
            {
                var tagsService = SingletonBase<ServiceTag>.GetInstance();
                var isDeleted = tagsService.DeleteTags(promoterId);
                return Request.CreateResponse(HttpStatusCode.OK, isDeleted);
            }
            catch (NullIdPromoterException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
            }
        }
    }
}
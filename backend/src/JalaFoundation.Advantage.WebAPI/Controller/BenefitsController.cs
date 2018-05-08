// <copyright file="BenefitsController.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.WebAPI.Controller
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using BusinessLogic.Exceptions;
    using BusinessLogic.Services;    
    using Models;
    using WebAPI.Validation;

    [EnableCors(origins: "*", headers: "*", methods: "*")]

    /// <summary>
    /// The controller for the Benefits related request
    /// </summary>
    public class BenefitsController : ApiController
    {
        /// <summary>
        /// Saves the recieved benefit
        /// </summary>
        /// <param name="benefit">
        /// The benefit to be saved
        /// </param>
        /// <returns> 
        /// A Created Http Status and a message on success or a Internal Server Error on fail
        /// </returns>
        [HttpPost]
        [Route("api/v1/benefits")]
        public HttpResponseMessage Post(Benefit benefit)
        {
            var formatErrorLists = ModelValidator.Validate(benefit);

            if (formatErrorLists.Count() > 0)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, formatErrorLists);
            }

            try
            {
                var serviceAccount = ServicePromotion.GetInstance();
                var created = serviceAccount.CreateBenefit(benefit);
                return Request.CreateResponse(HttpStatusCode.Created, "The benefit have been Created");
            }
            catch (BenefitNotCreatedException)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "An error Happened, The benefit have not been Created");
            }
        }

        /// <summary>
        /// Get the list of all benefits
        /// </summary>
        /// <returns>
        /// A HttpResponseMessage with status code 200 if the list has items and an AdvantageList object in the body
        /// A HttpResponseMessage with status code 204 if the list is empty and an AdvantageList object in the body
        /// </returns>
        [HttpGet]
        [Route("api/v1/benefits")]
        public HttpResponseMessage Get()
        {
            try
            {
                var benefitService = SingletonBase<ServiceAdvantage>.GetInstance();
                var advantagesList = benefitService.GetAdvantagesList();

                return Request.CreateResponse(HttpStatusCode.OK, advantagesList);
            }
            catch (EmptyAdvantageListException e)
            {
                return Request.CreateResponse(HttpStatusCode.NoContent, e.Message);
            }
        }

        /// <summary>
        /// Get a Benefit object
        /// </summary>
        /// <param name="id">
        /// The id parameter is a unique identifier for a benefit
        /// </param>
        /// <returns>return an Benefit based in his id</returns>
        [HttpGet]
        [Route("api/v1/benefits/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var advantageService = SingletonBase<ServiceAdvantage>.GetInstance();
                var benefit = advantageService.GetAdvantage(id);

                return Request.CreateResponse(HttpStatusCode.OK, benefit);
            }
            catch (NullAdvantageException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
            }
        }

        /// <summary>
        /// Get a list of benefits a specific category
        /// </summary>
        /// <param name="category">
        /// The name of a category
        /// </param>
        /// <returns>
        /// An AdvantageListDTO with their benefits of a category
        /// </returns>
        [HttpGet]
        [Route("api/v1/benefits/categories/{category}")]
        public HttpResponseMessage GetBenefits(string category)
        {
            try
            {
                var advantageService = SingletonBase<ServiceAdvantage>.GetInstance();
                var benefits = advantageService.GetBenefitsByCategory(category);

                return Request.CreateResponse(HttpStatusCode.OK, benefits);
            }
            catch (NullAdvantageException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
            }
        }

        /// <summary>
        /// Update a benefit
        /// </summary>
        /// <param name="id">
        /// The id of the benefit to update
        /// </param>
        /// <param name="benefit">
        /// The benefit with the new information
        /// </param>
        /// <returns>
        /// A status code 200 if the update was succesfully
        /// </returns>
        [HttpPut]
        [Route("api/v1/benefits/{id}")]
        public HttpResponseMessage Put(int id, [FromBody] Benefit benefit)
        {
            try
            {
                var advantageService = SingletonBase<ServiceAdvantage>.GetInstance();

                if (advantageService.UpdateBenefit(id, benefit))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "The benefit was updated succesfully");
                }

                return Request.CreateResponse(HttpStatusCode.OK, "No changes were made");
            }
            catch (NullAdvantageException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "That benefit does not exist");
            }
        }

        /// <summary>
        /// Delete a specific benefit by id
        /// </summary>
        /// <param name="id">
        /// The id of the benefit
        /// </param>
        /// <returns>
        /// A true if the benefit was deleted and false if the operation of delete is failed
        /// </returns>
        [HttpDelete]
        [Route("api/v1/benefits/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var advantageService = SingletonBase<ServiceAdvantage>.GetInstance();
                var result = advantageService.DeleteBenefit(id);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (NullAdvantageException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
            }
        }
    }
}
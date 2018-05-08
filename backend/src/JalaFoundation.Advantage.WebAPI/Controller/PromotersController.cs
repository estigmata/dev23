// <copyright file="PromotersController.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.WebAPI.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using JalaFoundation.Advantage.BusinessLogic.Exceptions;
    using JalaFoundation.Advantage.BusinessLogic.Services;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// This class is controller of Promoters
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PromotersController : ApiController
    {
        /// <summary>
        /// This Methods returns a list of the All Promoters
        /// </summary>
        /// <returns>Returns a List of Promoters</returns>
        public HttpResponseMessage GetPromoters()
        {
            try
            {
                var coordinationService = SingletonBase<ServiceCoordinator>.GetInstance();
                var promotersList = coordinationService.GetPromotersList()
                .Select(promoters => new
                 {
                     id = promoters.Id,
                     company = promoters.Name,
                     phone = (promoters.Stores.Count > 0) ? promoters.Stores.ElementAt(0).Phone : null,
                     address = (promoters.Stores.Count > 0) ? promoters.Stores.ElementAt(0).Address : null,
                     contact = promoters.Contact.Name
                 });

                return Request.CreateResponse(HttpStatusCode.OK, promotersList);
            }
            catch (NullListPromotersException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
            }
            catch (NullContactException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
            }
        }

        /// <summary>
        /// This Method return a model Promoter updated
        /// </summary>
        /// <param name="promoter"> This is model that will be updated</param>
        /// <returns>Return a model Promoter</returns>
        public HttpResponseMessage UpdatePromoter(Promoter promoter)
        {
            try
            {
                var promoterService = SingletonBase<ServicePromoter>.GetInstance();
                var updatedPromoter = promoterService.UpdatePromoter(promoter);
                return Request.CreateResponse(HttpStatusCode.OK, updatedPromoter);
            }
            catch (NullPromoterException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
            }
        }

        /// <summary>
        /// Get the promoter for the specified userId
        /// </summary>
        /// <param name="userId">This is a UserID of the Promoter</param>
        /// <returns> The Promoter for the given userId</returns>
        public HttpResponseMessage GetPromoter(int userId)
        {
            try
            {
                var promoterService = SingletonBase<ServicePromoter>.GetInstance();
                var promoter = promoterService.GetPromoter(userId);
                var contact = new { id = promoter.Contact.Id, name = promoter.Contact.Name, phone = promoter.Contact.Phone, email = promoter.Contact.Email };
                var category = new { id = promoter.Category.Id, name = promoter.Category.Name };
                var image = new { id = promoter.Image.Id, imageSerialized = promoter.Image.ImageSerialized };
                var tags = promoter.PromoterTag.Select(tag => new { id = tag.TagID, name = tag.Tag.Name });

                var result = new { id = promoter.Id, name = promoter.Name, contact, category, image, tags };
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (NullPromoterException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "The promoter does not exist");
            }
        }

        /// <summary>
        /// Add a new store to the specified promoter 
        /// </summary>
        /// <param name="promoterId">This is a PromterId of the Promoter</param>
        /// <param name="store">This is a new store that add to the Promoter</param>
        /// <returns>return a new store added of the specific promoter</returns>
        [HttpPost]
        [Route("api/v1/promoters/{promoterId:int}/stores")]
        public HttpResponseMessage AddStore(int promoterId, [FromBody] Store store)
        {
            try
            {
                var promoterService = SingletonBase<ServicePromoter>.GetInstance();
                var newStore = promoterService.AddStore(promoterId, store);

                var returnStore = new { id = newStore.Id, name = newStore.Name, phone = newStore.Phone, address = newStore.Address };

                return Request.CreateResponse(HttpStatusCode.OK, returnStore);
            }
            catch (NullPromoterException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
            }
        }

        /// <summary>
        /// Get a list of stores for the specified promoterId
        /// </summary>
        /// <param name="promoterId">This is a PromterId of the Promoter</param>
        /// <returns>return a List of stores for the specific promoter</returns>
        [HttpGet]
        [Route("api/v1/promoters/{promoterId:int}/stores")]
        public HttpResponseMessage GetStores(int promoterId)
        { 
            try
            { 
                var promoterService = SingletonBase<ServicePromoter>.GetInstance();
                var storesList = promoterService.GetStores(promoterId)
                    .Select(store => new
                    {
                        id = store.Id,
                        name = store.Name,
                        address = store.Address,
                        phone = store.Phone
                    });

                return Request.CreateResponse(HttpStatusCode.OK, storesList);
            }
            catch (NullPromoterException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
            }
        }

        /// <summary>
        /// Get a list of benefits for the specified promoterId
        /// </summary>
        /// <param name="promoterId">
        /// Represent id of a promoter
        /// </param>
        /// <returns>
        /// Return a list of benefit with specific id promoter
        /// </returns>
        [HttpGet]
        [Route("api/v1/promoters/{promoterId:int}/benefits")]
        public HttpResponseMessage GetBenefits(int promoterId)
        {
            try
            {
                var benefitService = SingletonBase<ServiceAdvantage>.GetInstance();
                var benefitList = benefitService.GetBenefitByPromoter(promoterId);

                return Request.CreateResponse(HttpStatusCode.OK, benefitList);
            }
            catch (EmptyAdvantageListException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
            }
        }
    }
}
// <copyright file="SchedulesController.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.WebAPI.Controller
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using JalaFoundation.Advantage.BusinessLogic.Exceptions;
    using JalaFoundation.Advantage.BusinessLogic.Services;
    using JalaFoundation.Advantage.Models;
    using JalaFoundation.Advantage.WebAPI.Validation;

    /// <summary>
    /// This class is controller for all the endpoints of SchedulesController
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SchedulesController : ApiController
    {
        /// <summary>
        /// Create the Schedule of the week for a promoter
        /// </summary>
        /// <param name="scheduleList">This is a list Of PromoterSchedules for a Promoter</param>
        /// <returns>return true if all the schedules have been created successfully</returns>
        [HttpPost]
        [Route("api/v1/schedules/")]
        public HttpResponseMessage Post(List<PromoterSchedule> scheduleList)
        {
            try
            {
                var promoterService = SingletonBase<ServicePromoter>.GetInstance();
                var newStore = promoterService.CreatePromoterSchedule(scheduleList);
                return Request.CreateResponse(HttpStatusCode.OK, newStore);
            }
            catch (NotCreatedScheduleException e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
            }
        }

        /// <summary>
        /// Get the Schedules for the specified promoterId
        /// </summary>
        /// <param name="promoterId">This is a PromoterID of the Promoter</param>
        /// <returns> The Schedule for the given promoterId</returns>
        [HttpGet]
        [Route("api/v1/schedules/promoter/{promoterId}")]
        public HttpResponseMessage GetSchedulesByPromoter(int promoterId)
        {
            try
            {
                var promoterService = SingletonBase<ServicePromoter>.GetInstance();
                var promoterSchedule = promoterService.GetPromoterSchedule(promoterId);
                return Request.CreateResponse(HttpStatusCode.OK, promoterSchedule);
            }
            catch (NullListPromoterScheduleException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "The promoter does not exist");
            }
        }
    }
}
// <copyright file="PromoterScheduleRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.DataAccess.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The PromoterScheduleRepository class contains methods that interact with the database of the PromoterSchedule table.
    /// </summary>
    public class PromoterScheduleRepository : IPromoterScheduleRepository
    {
        /// <summary>
        /// Get the list of PromoterSchedule belongs to promoterId
        /// </summary>
        /// <param name="promoterId">
        /// This is a specific promoterId of a Promoter
        /// </param>
        /// <returns>
        /// A list of PromoterSchedule
        /// </returns>
        public List<PromoterSchedule> GetPromoterSchedule(int promoterId)
        {
            using (var context = new AdvantageContext())
            {
                context.Configuration.ProxyCreationEnabled = false;
                return context.PromoterSchedules
                .Include("Schedule")
                .Where(b => b.PromoterId == promoterId).ToList();
            }
        }
    }
}

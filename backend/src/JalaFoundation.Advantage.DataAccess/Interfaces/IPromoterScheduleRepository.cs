// <copyright file="IPromoterScheduleRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.DataAccess.Interfaces
{
    using System.Collections.Generic;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The IPromoterScheduleRepository class contains methods that interact with the database of the Schedule table.
    /// </summary>
    public interface IPromoterScheduleRepository
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
        List<PromoterSchedule> GetPromoterSchedule(int promoterId);
    }
}

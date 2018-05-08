// <copyright file="IScheduleRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.DataAccess.Interfaces
{
    using System.Collections.Generic;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The IScheduleRepository interface implements methods to interact with Schedule at database
    /// </summary>
    public interface IScheduleRepository
    {
        /// <summary>
        /// Create a new List of PromoterSchedule and a schedule
        /// </summary>
        /// <param name="scheduleList">
        /// The scheduleList represents the new List of PromoterSchedule to be Created
        /// </param>
        /// <returns>Return true if all the List of PromoterSchedule have been created</returns>
        bool CreatePromoterSchedule(IList<PromoterSchedule> scheduleList);

        /// <summary>
        /// Gets the list of Schedule of a promoter
        /// with the specifit promoter id
        /// </summary>
        /// <param name="id">
        /// The id represents the id property of a promoter to be
        /// search in PromoterSchedule
        /// </param>
        /// <returns>Return a list of schedule</returns>
        List<Schedule> GetListSchedule(int id);
    }
}

// <copyright file="ScheduleRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.DataAccess.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using JalaFoundation.Advantage.DataAccess.Exceptions;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.Models;    

    /// <summary>
    /// The ScheduleRepository class contains methods that interact with the database of the PromoterSchedule table.
    /// </summary>
    public class ScheduleRepository : IScheduleRepository
    {
        /// <summary>
        /// Create a new List of PromoterSchedule and a schedule
        /// </summary>
        /// <param name="scheduleList">
        /// The scheduleList represents the new List of PromoterSchedule to be Created
        /// </param>
        /// <returns>Return true if all the List of PromoterSchedule have been created</returns>
        public bool CreatePromoterSchedule(IList<PromoterSchedule> scheduleList)
        {
            bool result = true;
            using (var context = new AdvantageContext())
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    if (scheduleList.Count > 0)
                    {
                        var promoterId = scheduleList[0].PromoterId;
                        var schedules = context.PromoterSchedules
                            .Where(ps => ps.PromoterId == promoterId)
                            .Select(ps => ps.Schedule)
                            .ToList();
                        context.Schedules.RemoveRange(schedules.ToList());
                    }

                    foreach (var item in scheduleList)
                    {
                        context.PromoterSchedules.Add(item);
                        context.SaveChanges();
                        if (item.Id <= 0)
                        {
                            throw new ScheduleNotCreatedException(item.Schedule);
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    transaction.Rollback();
                    result = false;
                }
            }

            return result;
        }

        /// <summary>
        /// Gets the list of Schedule of a promoter
        /// with the specifit promoter id
        /// </summary>
        /// <param name="id">
        /// The id represents the id property of a promoter to be
        /// search in PromoterSchedule
        /// </param>
        /// <returns>Return a list of schedule</returns>
        public List<Schedule> GetListSchedule(int id)
        {
            using (var context = new AdvantageContext())
            {
                return context.PromoterSchedules
                    .Where(p => p.PromoterId == id)
                    .Select(p => p.Schedule)
                    .ToList();
            }
        }
    }
}

// <copyright file="ScheduleNotCreatedException.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Exceptions
{
    using System;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// An Exception thrown when the schedule list have not been created
    /// </summary>
    public class ScheduleNotCreatedException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleNotCreatedException"/> class.
        /// </summary>
        public ScheduleNotCreatedException() : base("Exception: The schedule have not been created.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleNotCreatedException"/> class.
        /// </summary>
        /// <param name="schedule">
        /// Represents the not created schedule
        /// </param>
        public ScheduleNotCreatedException(Schedule schedule) 
            : base($"Exception: The following schedule have not been created: day {schedule.Day},  From {schedule.From} to {schedule.To}")
        {
        }
    }
}

// <copyright file="NullListPromoterScheduleException.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Exceptions
{
    using System;

    /// <summary>
    /// The NullListPromoterScheduleException is thrown when a list of PromoterSchedule is not found
    /// </summary>
    public class NullListPromoterScheduleException : Exception
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="NullListPromoterScheduleException"/> class.
        /// </summary>
        public NullListPromoterScheduleException() : base("Exception: The List of Promoter Shedules is null.")
        {
        }
    }
}

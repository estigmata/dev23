// <copyright file="NotCreatedScheduleException.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.Exceptions
{
    using System;

    /// <summary>
    /// An Exception thrown when the schedule list have not been created
    /// </summary>
    public class NotCreatedScheduleException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotCreatedScheduleException"/> class.
        /// </summary>
        public NotCreatedScheduleException() : base("Exception: The schedule have not been created.")
        {
        }    
    }
}

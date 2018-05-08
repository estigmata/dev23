// <copyright file="NullPromoterException.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Exceptions
{
    using System;

    /// <summary>
    /// The NullPromoterException is thrown when a Promoter is not found
    /// </summary>
    public class NullPromoterException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullPromoterException"/> class.
        /// </summary>
        public NullPromoterException() : base("Exception: The promoter does not exist.")
        {
        }
    }
}

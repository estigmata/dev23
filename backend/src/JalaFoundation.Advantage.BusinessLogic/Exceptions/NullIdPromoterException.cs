// <copyright file="NullIdPromoterException.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Exceptions
{
    using System;

    /// <summary>
    /// The NullIdPromoterException is thrown when a promoterId is not null.
    /// </summary>
    public class NullIdPromoterException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullIdPromoterException"/> class.
        /// </summary>
        public NullIdPromoterException() : base("Exception: The id promoter is null")
        {
        }
    }
}

// <copyright file="NullListPromotersException.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Exceptions
{
    using System;

    /// <summary>
    /// The NullListCoordinatorException is thrown when a list of Promoters is not found
    /// </summary>
    public class NullListPromotersException : Exception
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="NullListPromotersException"/> class.
        /// </summary>
        public NullListPromotersException() : base("Exception: The List Promoters is null.")
        {
        }
    }
}

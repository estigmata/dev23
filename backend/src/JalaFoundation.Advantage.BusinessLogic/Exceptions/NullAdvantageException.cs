// <copyright file="NullAdvantageException.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.Exceptions
{
    using System;

    /// <summary>
    /// The NullAdvantageException is thrown when a benefit is not found
    /// </summary>
    public class NullAdvantageException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullAdvantageException"/> class.
        /// </summary>
        public NullAdvantageException() : base("Exception: The Benefit Model is Empty.")
        {
        }
    }
}

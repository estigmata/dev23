// <copyright file="NullFormException.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Exceptions
{
    using System;

    /// <summary>
    /// The NullFormException is thrown when a form is not found
    /// </summary>
    public class NullFormException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullFormException"/> class.
        /// </summary>
        public NullFormException() : base("Exception: The Form Model is null.")
        {
        }
    }
}

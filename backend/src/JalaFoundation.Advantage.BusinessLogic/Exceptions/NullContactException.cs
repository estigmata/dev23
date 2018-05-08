// <copyright file="NullcontactException.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Exceptions
{
    using System;

    /// <summary>
    /// The NullContactException is thrown when a contact is not found
    /// </summary>
    public class NullContactException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullContactException"/> class.
        /// </summary>
        public NullContactException() : base("Exception: The Contact Model is null.")
        {
        }
    }
}

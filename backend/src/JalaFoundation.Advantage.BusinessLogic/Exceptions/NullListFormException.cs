// <copyright file="NullListFormException.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Exceptions
{
    using System;

    /// <summary>
    /// The NullFormException is throws when the list of forms is null
    /// </summary>
    public class NullListFormException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullListFormException"/> class.
        /// </summary>
        public NullListFormException() : base("Exception: The List Form is null.")
        {
        }
    }
}

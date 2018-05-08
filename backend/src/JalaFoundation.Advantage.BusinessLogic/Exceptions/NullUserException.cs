// <copyright file="NullUserException.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Exceptions
{
    using System;

    /// <summary>
    /// The NullUserException class extends from Exception Class and 
    /// throws an exception when the user does not exist
    /// </summary>
    public class NullUserException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullUserException"/> class and send a 
        /// message that the user is null.
        /// </summary>
        public NullUserException()
            : base("Exception: The user is null.")
        {
        }
    }
}

// <copyright file="NullRoleException.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Exceptions
{
    using System;

    /// <summary>
    /// The NullRoleException class extends from Exception Class
    /// </summary>
    public class NullRoleException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullRoleException"/> class.
        /// </summary>
        public NullRoleException()
            : base(string.Format("Exception: The role is null."))
        {
        }
    }
}

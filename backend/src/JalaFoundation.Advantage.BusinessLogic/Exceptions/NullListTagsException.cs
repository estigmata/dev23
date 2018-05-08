// <copyright file="NullListTagsException.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Exceptions
{
    using System;

    /// <summary>
    /// The NullListTagsException is thrown when a list of Tags is not found
    /// </summary>
    public class NullListTagsException : Exception
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="NullListTagsException"/> class.
        /// </summary>
        public NullListTagsException() : base("Exception: The List Tags is empty.")
        {
        }
    }
}

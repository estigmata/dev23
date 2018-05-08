// <copyright file="NullListCategoryException.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.Exceptions
{
    using System;

    /// <summary>
    /// The NullListCategoryException is throws when the list of categories is null
    /// </summary>
    public class NullListCategoryException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullListCategoryException"/> class.
        /// </summary>
        public NullListCategoryException() : base("Exception: The List Category is empty.")
        {
        }
    }
}

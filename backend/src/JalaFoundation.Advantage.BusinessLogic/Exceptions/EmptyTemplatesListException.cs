// <copyright file="EmptyTemplatesListException.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.Exceptions
{
    using System;

    /// <summary>
    /// An Exception thrown when the a list of templates is empty
    /// </summary>
    public class EmptyTemplatesListException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmptyTemplatesListException"/> class.
        /// </summary>
        public EmptyTemplatesListException() : base("The List of Templates is empty")
        {
        }
    }
}

// <copyright file="EmptyAdvantageListException.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.Exceptions
{
    using System;

    /// <summary>
    /// An Exception thrown when the property Total of AdvantagesList is zero
    /// </summary>
    public class EmptyAdvantageListException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmptyAdvantageListException"/> class.
        /// </summary>
        public EmptyAdvantageListException() : base("Exception: The List of Advantages is empty.")
        {
        }
    }
}

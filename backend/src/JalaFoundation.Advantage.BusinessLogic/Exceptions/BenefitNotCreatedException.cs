// <copyright file="BenefitNotCreatedException.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Exceptions
{
    using System;

    /// <summary>
    /// The BenefitNotCreatedException is thrown when a Benefit have not been created
    /// </summary>
    public class BenefitNotCreatedException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BenefitNotCreatedException"/> class.
        /// </summary>
        public BenefitNotCreatedException()
            : base("The benefit has not been created")
        {
        }
    }
}

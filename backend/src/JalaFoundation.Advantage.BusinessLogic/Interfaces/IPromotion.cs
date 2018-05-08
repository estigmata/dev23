// <copyright file="IPromotion.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.Interfaces
{
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The IPromotion interface define the methods necessary to interact with the Data Access Project
    /// </summary>
    public interface IPromotion
    {
        /// <summary>
        /// Calls to repository to save a Benefit
        /// </summary>
        /// <param name="model">
        /// A model of a benefit to be saved
        /// </param>
        /// <returns>
        /// Returns true if it have been created and false on fail
        /// </returns>
        bool CreateBenefit(Benefit model);

        /// <summary>
        /// Set the repository instance of a benefit used for this class
        /// </summary>
        /// <param name="benefitRepository">
        /// An instance of IBenefitRepository to be set
        /// </param>
        void SetBenefitRepository(IBenefitRepository benefitRepository);
    }
}

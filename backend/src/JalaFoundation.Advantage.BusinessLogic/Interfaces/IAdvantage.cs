// <copyright file="IAdvantage.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.Interfaces
{
    using System.Collections.Generic;
    using JalaFoundation.Advantage.BusinessLogic.DTO;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// Defines the necessary methods to communicate with a service that operates on advantages
    /// </summary>
    public interface IAdvantage
    {
        /// <summary>
        /// Get the list of advantages
        /// </summary>
        /// <returns>
        /// A list of advantages
        /// </returns>
        AdvantagesListDTO GetAdvantagesList();

        /// <summary>
        /// Return a Benefit object using his specific id parameter
        /// </summary>
        /// <param name="id">
        /// The id represents the id property from the searched Benefit
        /// </param>
        /// <returns>return an Benefit with the specified id</returns>
        Benefit GetAdvantage(int id);

        /// <summary>
        /// Get the list of all benefits of a specific promoter
        /// </summary>
        /// <param name="promoterId">
        /// The param is the id of a promoter
        /// </param>
        /// <returns>
        /// Return a BenefitDTO list
        /// </returns>
        List<BenefitDTO> GetBenefitByPromoter(int promoterId);

        /// <summary>
        /// Update the Model of a Benefit
        /// </summary>
        /// <param name="benefitId">
        /// The id of the benefit to be updated
        /// </param>
        /// <param name="newBenefit">
        /// The benefit with the new information
        /// </param>
        /// <returns>
        /// True if the benefit was updated sucesfully or False if not
        /// </returns>
        bool UpdateBenefit(int benefitId, Benefit newBenefit);
    }
}

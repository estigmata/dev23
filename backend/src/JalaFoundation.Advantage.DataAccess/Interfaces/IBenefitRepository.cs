// <copyright file="IBenefitRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Interfaces
{
    using System.Collections.Generic;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// Defines the methods to do queries related to benefits in the database
    /// </summary>
    public interface IBenefitRepository : IRepository<Benefit>
    {
        /// <summary>
        /// Get the list of all benefits
        /// </summary>
        /// <returns>
        /// A list of benefits
        /// </returns>
        IList<Benefit> GetAllWithPromoters();

        /// <summary>
        /// Return an Benefit from the database using his specific id as parameter
        /// </summary>
        /// <param name="id">
        /// The id represents the id property from the searched Banefit
        /// </param> 
        /// <returns>return an Benefit with the specified id</returns>
        Benefit Get(int id);

        /// <summary>
        /// Get the list of benefits belongs to categoryId
        /// </summary>
        /// <param name="categoryId">
        /// This is a specific category
        /// </param>
        /// <returns>
        /// Returns a list of Benefits 
        /// </returns>
        IList<Benefit> GetBenefitsByCategory(int categoryId);

        /// <summary>
        /// Update a Model of a Benefit
        /// </summary>
        /// /// <param name="benefitId">
        /// The id of the benefit to be updated
        /// </param>
        /// <param name="newBenefit">
        /// The benefit with the new information
        /// </param>
        /// <returns>
        /// True if the benefit was updated sucesfully or False if not
        /// </returns>
        bool Update(int benefitId, Benefit newBenefit);

        /// <summary>
        /// Get the list of benefits belongs to promotersId
        /// </summary>
        /// <param name="promoterId">
        /// This is a specific Promoter
        /// </param>
        /// <returns>Returns a list of Benefits</returns>
        IList<Benefit> GetBenefitsByPromoter(int promoterId);

        /// <summary>
        /// Delete a specific benefit by id in Benefits table
        /// </summary>
        /// <param name="id">
        /// The id of the benefit
        /// </param>
        /// <returns>
        /// A true if the benefit was deleted and false if the operation of delete is failed
        /// </returns>
        bool Delete(int id);
    }
}
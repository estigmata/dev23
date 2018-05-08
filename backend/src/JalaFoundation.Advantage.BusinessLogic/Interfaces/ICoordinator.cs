// <copyright file="ICoordinator.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Interfaces
{
    using System.Collections.Generic;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The ICoordinator interface define the methods that Coordinators necessary to interact with the Data Access Project
    /// </summary>
    public interface ICoordinator
    {
        /// <summary>
        ///  Gets the Promoters of the PromotersRepository
        /// </summary>
        /// <returns>
        ///  Returns a IList the Promoters
        /// </returns>
        IList<Promoter> GetPromotersList();

        /// <summary>
        /// Gets the Contact of an Promoter especified by his contactID
        /// </summary>
        /// <param name ="id">
        /// The id from the searched contact
        /// </param>
        /// <returns>
        /// Returns a Contact of the contactRepository
        /// </returns>
        Contact GetContactById(long id);
    }
}

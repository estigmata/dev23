// <copyright file="IPromoterRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Interfaces
{
    using System.Collections.Generic;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The IPromoterRepository class contains methods that interact with the database of the Promoter table.
    /// </summary>
    public interface IPromoterRepository : IRepository<Promoter>
    {
        /// <summary>
        /// Return an Promoter from the database using his specific id as parameter
        /// </summary>
        /// <param name="id">
        /// The id represents the id property from the searched Promoter
        /// </param>
        /// <returns>return an Promoter with the specified id</returns>
        Promoter Get(int id);

        /// <summary>
        /// This method obtain the list of Promoters that exist in the database
        /// </summary>
        /// <returns>
        /// A list of promoters
        /// </returns>
        IList<Promoter> GetPromotersList();
    }
}
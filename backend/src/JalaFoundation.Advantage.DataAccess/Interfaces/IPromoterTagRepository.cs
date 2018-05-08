// <copyright file="IPromoterTagRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.DataAccess.Interfaces
{
    using System.Collections.Generic;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The IPromoterTagRepository interface contains methods that interact with the database of the IPromoterTagRepository table.
    /// </summary>
    public interface IPromoterTagRepository : IRepository<PromoterTag>
    {
        /// <summary>
        /// Return a List of tags from the database using his specific promoterId as parameter
        /// </summary>
        /// <param name="promoterId">
        /// The promoterId represents the id property from the promoter
        /// </param>
        /// <returns>return a list of tags of a specified promotor</returns>
        List<PromoterTag> GetTagsByPromoter(int promoterId);

        /// <summary>
        /// Delete the tags from the database using his specific promoterId as parameter
        /// </summary>
        /// <param name="promoterId">
        /// The promoterId represents the id property from the promoter
        /// </param>
        /// <returns>return a bool</returns>
        bool DeleteTagsByPromoter(int promoterId);
    }
}

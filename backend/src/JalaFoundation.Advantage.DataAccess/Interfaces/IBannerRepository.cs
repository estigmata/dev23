// <copyright file="IBannerRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Interfaces
{
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The IBannerRepository interface have the common methods for Repositories
    /// </summary>
    public interface IBannerRepository
    {
        /// <summary>
        /// Return an Banner from the database using his specific id as parameter
        /// </summary>
        /// <param name="id">
        /// The id represents the id property from the searched Banner
        /// </param>
        /// <returns>return an Banner with the specified id</returns>
        Banner Get(long id);
    }
}

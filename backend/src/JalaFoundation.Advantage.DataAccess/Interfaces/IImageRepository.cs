// <copyright file="IImageRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Interfaces
{
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The ImageRepository class implements methods from IRepository
    /// </summary>
    public interface IImageRepository : IRepository<Image>
    {
        /// <summary>
        /// Return an Image from the database using his specific id as parameter
        /// </summary>
        /// <param name="id">
        /// The id represents the id property from the searched Image
        /// </param>
        /// <returns>return an Image with the specified id</returns>
        Image Get(int id);
    }
}
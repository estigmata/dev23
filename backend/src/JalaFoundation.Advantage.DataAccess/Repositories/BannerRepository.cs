// <copyright file="BannerRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Repositories
{
    using System.Linq;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The BannerRepository class implements methods from IRepository
    /// </summary>
    public class BannerRepository : IBannerRepository
    {
        /// <summary>
        /// Return an Banner from the database using his specific id as parameter
        /// </summary>
        /// <param name="id">
        /// The id represents the id property from the searched Banner
        /// </param>
        /// <returns>return an Banner with the specified id</returns>
        public Banner Get(long id)
        {
            using (var context = new AdvantageContext())
            {
                return context.Banners.Find(id);
            }
        }
    }
}

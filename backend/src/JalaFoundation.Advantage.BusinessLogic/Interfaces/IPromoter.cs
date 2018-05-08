// <copyright file="IPromoter.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Interfaces
{
    using System.Collections.Generic;
    using Models;    

    /// <summary>
    /// The IPromoter interface define the methods necessary to interact with the Data Access Project
    /// </summary>
    public interface IPromoter
    {
        /// <summary>
        /// Updates a Promoter
        /// </summary>
        /// <param name="promoter">
        /// The promoter param is a Model of Promoter that be updated in the method
        /// </param>
        /// <returns>
        /// Return its Promoter Model updated 
        /// </returns>
        Promoter UpdatePromoter(Promoter promoter);

        /// <summary>
        /// Gets a Model of a Contact specified by his contactId
        /// </summary>
        /// <param name="contactId">
        /// The contactId from the searched Contact
        /// </param>
        /// <returns>
        /// Return its Contact Model
        /// </returns>
        Contact GetContact(int contactId);

        /// <summary>
        /// Gets a Model of a Category specified by his categoryId
        /// </summary>
        /// <param name="categoryId">
        /// The categoryId from the searched Category
        /// </param>
        /// <returns>
        /// Return its Category Model
        /// </returns>
        Category GetCategory(int categoryId);

        /// <summary>
        /// Gets a Model of a Image specified by his imageId
        /// </summary>
        /// <param name="imageId">
        /// The imageId from the searched Image
        /// </param>
        /// <returns>
        /// Return its Image Model
        /// </returns>
        Image GetImage(int imageId);

        /// <summary>
        /// Add a new store to the specified Promoter 
        /// </summary>
        /// <param name="promoterId">This is the PromoterId of the Promoter</param>
        /// <param name="store">This is a new store that will be added to the Promoter</param>
        /// <returns>return a new Store </returns>
        Store AddStore(int promoterId, Store store);

        /// <summary>
        /// Create a list of schedules for a promoter
        /// </summary>
        /// <param name="scheduleList">This is the list of Schedules for a Promoter</param>
        /// <returns>return True if all the schedules have been created </returns>
        bool CreatePromoterSchedule(IList<PromoterSchedule> scheduleList);
    }
}

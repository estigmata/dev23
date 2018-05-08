// <copyright file="StoreRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Repositories
{
    using System;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The StoreRepository class implements methods from IRepository and IStoreRepository for interact with the database of the Store table.
    /// </summary>
    public class StoreRepository : IRepository<Store>, IStoreRepository
    {
        /// <summary>
        /// Create a new Store model
        /// </summary>
        /// <param name="model">
        /// Store to be added at the database
        /// </param>
        /// <returns>
        /// Returns the saved Store with his respective Id
        /// </returns>
        public Store Create(Store model)
        {
            using (var context = new AdvantageContext())
            {
                context.Stores.Add(model);
                context.SaveChanges();
                return model;
            }
        }

        /// <summary>
        /// Update a specific Benefit model
        /// </summary>
        /// <param name="model">
        /// Store to be updated at the database
        /// </param>
        /// <returns>
        /// Returns the updated and saved Store 
        /// </returns>
        public Store Update(Store model)
        {
            throw new NotImplementedException();
        }
    }
}

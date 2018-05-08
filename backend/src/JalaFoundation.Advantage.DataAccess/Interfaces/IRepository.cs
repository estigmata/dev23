// <copyright file="Irepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Interfaces
{
    /// <summary>
    /// IRepository interface have the common methods for Repositories
    /// </summary>
    /// <typeparam name="T">
    /// T is a Model Class
    /// </typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Save a T Object in Database
        /// </summary>
        /// <param name="model">
        /// model is the T Model to be saved
        /// </param>
        /// <returns>
        /// Returns a T Object
        /// </returns>
        T Create(T model);

        /// <summary>
        /// Update a especific model
        /// </summary>
        /// <param name="model">
        /// The model that be updated
        /// </param>
        /// <returns>
        /// Returns a model updated
        /// </returns>
        T Update(T model);
    }
}

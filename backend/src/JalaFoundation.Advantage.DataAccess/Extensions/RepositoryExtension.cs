// <copyright file="RepositoryExtension.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.DataAccess.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using JalaFoundation.Advantage.DataAccess.Interfaces;

    /// <summary>
    /// RepositoryExtension class have the extrension methods
    /// </summary>
    public static class RepositoryExtension
    {
        /// <summary>
        /// Receives a match lambda function and run it in a where statement
        /// </summary>
        /// <typeparam name="T">
        /// T param represent a class type
        /// </typeparam>
        /// <param name="repository">
        /// Repository is an IRepository interface
        /// </param>
        /// <param name="match">
        /// Represent a lambda function for the where statement
        /// </param>
        /// <returns>
        /// Returns a T Object
        /// </returns>
        public static T GetByProperty<T>(this IRepository<T> repository, Func<T, bool> match) where T : class
        {
            using (var context = new AdvantageContext())
            {
                return context.Set<T>().FirstOrDefault(match);
            }
        }

        /// <summary>
        /// Receives a searchMatch lambda fuction and run it in a where statement
        /// </summary>
        /// <typeparam name="T">
        /// T param represent a class type
        /// </typeparam>
        /// <typeparam name="U">
        /// U param is the return class type
        /// </typeparam>
        /// <param name="repository">
        /// Repository is an IRepository interface
        /// </param>
        /// <param name="searchMatch">
        /// Represent a lambda function for the where method
        /// </param>
        /// /// <param name="selectMatch">
        /// Represent a lambda function for the Select method
        /// </param>
        /// <returns>
        /// Returns a U Object
        /// </returns>
        public static U GetPropertyWhere<T, U>(this IRepository<T> repository, Func<T, bool> searchMatch, Func<T, U> selectMatch) where T : class
        {
            using (var context = new AdvantageContext())
            {
                context.Configuration.ProxyCreationEnabled = false;

                return context.Set<T>().Where(searchMatch).Select(selectMatch).FirstOrDefault();
            }
        }

        /// <summary>
        /// Receives a selectMatch lambda function and run it in a where statement
        /// </summary>
        /// <typeparam name="T">
        /// T param represent a class type
        /// </typeparam>
        /// <typeparam name="U">
        /// U param is the return type class
        /// </typeparam>
        /// <param name="repository">
        /// The repository is the interface of IRepository
        /// </param>
        /// <param name="selectMatch">
        /// Represent a lambda function for the Select method
        /// </param>
        /// <returns>
        /// Return a ILits of U object
        /// </returns>
        public static IList<U> GetSelectedAs<T, U>(this IRepository<T> repository, Func<T, U> selectMatch) where T : class
        {
            using (var context = new AdvantageContext())
            {
                context.Configuration.ProxyCreationEnabled = false;

                return context.Set<T>().Select(selectMatch).ToList();
            }
        }

        /// <summary>
        /// Receives a whereMatch lambda function and run it in a where statement to get a list of stores
        /// </summary>
        /// <typeparam name="T">T param represent a class type</typeparam>
        /// <typeparam name="U">U param is the return type class</typeparam>
        /// <param name="repository">
        /// The repository is the interface of IRepository
        /// </param>
        /// <param name="selectMatch">
        /// Represent a lambda function for the Select method
        /// </param>
        /// <param name="whereMatch">
        /// Represent a lambda function for the Where method
        /// </param>
        /// <returns>Return a IList of U object</returns>
        public static IList<U> GetListWhere<T, U>(this IRepository<T> repository, Func<T, U> selectMatch, Func<T, bool> whereMatch) where T : class
        {
            using (var context = new AdvantageContext())
            {
                return context.Set<T>().Where(whereMatch)
                    .Select(selectMatch).ToList();
            }
        }
    }
}

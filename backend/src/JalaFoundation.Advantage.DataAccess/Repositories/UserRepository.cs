// <copyright file="UserRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Repositories
{
    using System;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The UserRepository class implements methods from IRoleRepository
    /// </summary>
    public class UserRepository : IRepository<User>, IUserRepository
    {
        /// <summary>
        /// Create a new Form model
        /// </summary>
        /// <param name="model">
        /// Form to be added at the database
        /// </param>
        /// <returns>
        /// Returns the saved Form with his respective Id
        /// </returns>
        public User Create(User model)
        {
            using (var context = new AdvantageContext())
            {
                context.Users.Add(model);
                context.SaveChanges();
                return model;
            }
        }

        /// <summary>
        /// Update a Model of a User
        /// </summary>
        /// <param name="model">
        /// The model User that be updated
        /// </param>
        /// <returns>
        /// Returns a model User updated
        /// </returns>
        public User Update(User model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return an User from the database using his specific id as parameter
        /// </summary>
        /// <param name="id">
        /// The id represents the id property from the searched User
        /// </param>
        /// <returns>return an User with the specified id</returns>
        public User Get(int id)
        {
            using (var context = new AdvantageContext())
            {
                return context.Users.Find(id);
            }
        }
    }
}

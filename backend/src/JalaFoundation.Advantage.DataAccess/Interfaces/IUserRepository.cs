// <copyright file="IUserRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Interfaces
{
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The UserRepository class implements methods from IRoleRepository
    /// </summary>
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// Return an User from the database using his specific id as parameter
        /// </summary>
        /// <param name="id">
        /// The id represents the id property from the searched User
        /// </param>
        /// <returns>return an User with the specified id</returns>
        User Get(int id);
    }
}
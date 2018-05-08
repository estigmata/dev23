// <copyright file="IAccount.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Interfaces
{
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The IAccount interface define the methods necesary to interact with the Data Access Project
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// Gets the Role of an user especified by its email and password
        /// </summary>
        /// <param name="email">
        /// The email of the searched user
        /// </param>
        /// <param name="password">
        /// The password of the searched user
        /// </param>
        /// <returns>
        /// The role of the user that matches the email and password
        /// </returns>
        Role GetRole(string email, string password);
    }
}

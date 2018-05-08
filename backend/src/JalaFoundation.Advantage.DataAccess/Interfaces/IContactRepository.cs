// <copyright file="IContactRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Interfaces
{
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The ContactRepository class contains methods that interact with the database of the Contact table.
    /// </summary>
    public interface IContactRepository : IRepository<Contact>
    {
        /// <summary>
        /// Return an Contact from the database using his specific id as parameter
        /// </summary>
        /// <param name="id">
        /// The id represents the id property from the searched Contact
        /// </param>
        /// <returns>return an Contact with the specified id</returns>
        Contact Get(int id);
    }
}
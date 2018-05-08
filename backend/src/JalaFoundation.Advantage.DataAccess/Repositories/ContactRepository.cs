// <copyright file="ContactRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Repositories
{
    using System;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The ContactRepository class contains methods that interact with the database of the Contact table.
    /// </summary>
    public class ContactRepository : IRepository<Contact>, IContactRepository
    {
        /// <summary>
        /// Create a new Contact model
        /// </summary>
        /// <param name="model">
        /// Contact to be added at the database
        /// </param>
        /// <returns>
        /// Returns the saved Contact with his respective Id
        /// </returns>
        public Contact Create(Contact model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update a Model of a Contact
        /// </summary>
        /// <param name="model">
        /// The model Contact that be updated
        /// </param>
        /// <returns>
        /// Returns a model Contact updated
        /// </returns>
        public Contact Update(Contact model)
        {
            using (var context = new AdvantageContext())
            {
                var updateModel = context.Contacts.Find(model.Id);
                updateModel.Name = model.Name;
                updateModel.Phone = model.Phone;
                updateModel.Email = model.Email;
                context.SaveChanges();
                return updateModel;
            }
        }

        /// <summary>
        /// Return an Contact from the database using his specific id as parameter
        /// </summary>
        /// <param name="id">
        /// The id represents the id property from the searched Contact
        /// </param>
        /// <returns>return an Contact with the specified id</returns>
        public Contact Get(int id)
        {
            using (var context = new AdvantageContext())
            {
                return context.Contacts.Find(id);
            }
        }
    }
}

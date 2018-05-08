// <copyright file="FormRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Repositories
{
    using System;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The FormRepository class implements methods from IRepository
    /// </summary>
    public class FormRepository : IRepository<Form>, IFormRepository
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
        public Form Create(Form model)
        {
            using (var context = new AdvantageContext())
            {
                context.Forms.Add(model);
                context.SaveChanges();
                return model;
            }
        }

        /// <summary>
        /// Update a Model of a Form
        /// </summary>
        /// <param name="model">
        /// The model Form that be updated
        /// </param>
        /// <returns>
        /// Returns a model Form updated
        /// </returns>
        public Form Update(Form model)
        {
            throw new NotImplementedException();
        }
    }
}

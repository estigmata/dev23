// <copyright file="ITemplateRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Interfaces
{
    using System.Collections.Generic;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// Defines the methods to do queries to the Templates table of the database
    /// </summary>
    public interface ITemplateRepository : IRepository<Template>
    {
        /// <summary>
        /// Get the list of all templates with schedule
        /// </summary>
        /// <returns>
        /// An IList of templates with schedules
        /// </returns>
        IList<Template> GetAll();
    }
}
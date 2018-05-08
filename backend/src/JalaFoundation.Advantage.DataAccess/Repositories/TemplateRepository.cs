// <copyright file="TemplateRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// This class contains methods to do queries to the Templates table of the database.
    /// </summary>
    public class TemplateRepository : ITemplateRepository
    {
        /// <summary>
        /// Add a new template to the Templates table of the database
        /// </summary>
        /// <param name="model">
        /// The template to be added
        /// </param>
        /// <returns>
        /// The template added to the database
        /// </returns>
        public Template Create(Template model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update a template of the Templates table of the database
        /// </summary>
        /// <param name="model">
        /// The template that contains the updated information
        /// </param>
        /// <returns>
        /// The template updated from the database
        /// </returns>
        public Template Update(Template model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the list of all templates with schedules
        /// </summary>
        /// <returns>
        /// An IList of templates with schedules
        /// </returns>
        public IList<Template> GetAll()
        {
            using (var context = new AdvantageContext())
            {
                return context.Templates
                    .Include("TemplateSchedule.Schedule")
                    .ToList();
            }
        }
    }
}

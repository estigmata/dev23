// <copyright file="TagRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.DataAccess.Repositories
{
    using System;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The TagRepository class contains methods that interact with the database of the Tag table.
    /// </summary>
    public class TagRepository : ITagRepository
    {
        /// <summary>
        /// Create a new Tag model
        /// </summary>
        /// <param name="model">
        /// Tag to be added at the database
        /// </param>
        /// <returns>
        /// Returns the saved Tag
        /// </returns>
        public Tag Create(Tag model)
        {
            using (var context = new AdvantageContext())
            {
                var tag = context.Tags.Add(model);
                context.SaveChanges();
                return tag;
            }
        }

        /// <summary>
        /// Update a Model of a Tag
        /// </summary>
        /// <param name="model">
        /// The model Tag that be updated
        /// </param>
        /// <returns>
        /// Returns a model Tag updated
        /// </returns>
        public Tag Update(Tag model)
        {
            using (var context = new AdvantageContext())
            {
                var updateModel = context.Tags.Find(model.Id);
                updateModel.Name = model.Name;
                context.SaveChanges();
                return updateModel;
            }
        }
    }
}

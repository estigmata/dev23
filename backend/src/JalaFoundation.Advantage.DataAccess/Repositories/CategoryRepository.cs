// <copyright file="CategoryRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Repositories
{
    using System;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The CategoryRepository class contains methods that interact with the database of the Category table.
    /// </summary>
    public class CategoryRepository : IRepository<Category>, ICategoryRepository
    {
        /// <summary>
        /// Create a new Category model
        /// </summary>
        /// <param name="model">
        /// Category to be added at the database
        /// </param>
        /// <returns>
        /// Returns the saved Category
        /// </returns>
        public Category Create(Category model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update a Model of a Category
        /// </summary>
        /// <param name="model">
        /// The model Category that be updated
        /// </param>
        /// <returns>
        /// Returns a model Category updated
        /// </returns>
        public Category Update(Category model)
        {
            using (var context = new AdvantageContext())
            {
                var updateModel = context.Categories.Find(model.Id);
                updateModel.Name = model.Name;
                context.SaveChanges();
                return updateModel;
            }
        }

        /// <summary>
        /// Return an Category from the database using his specific id as parameter
        /// </summary>
        /// <param name="id">
        /// The id represents the id property from the searched Category
        /// </param>
        /// <returns>return an Category with the specified id</returns>
        public Category Get(int id)
        {
            using (var context = new AdvantageContext())
            {
                return context.Categories.Find(id);
            }
        }
    }
}

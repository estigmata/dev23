// <copyright file="ICategory.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.Interfaces
{
    using System.Collections.Generic;
    using Models;

    /// <summary>
    /// The ICategory interface define the methods necessary to interact with the Data Access Project
    /// </summary>
    public interface ICategory
    {
        /// <summary>
        /// Gets the Categories of the Category Repository
        /// </summary>
        /// <returns>
        /// Returns a IList with columns Id and Name of the CategoryRepository
        /// </returns>
        IList<Category> GetCategoriesList();
    }
}

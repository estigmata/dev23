// <copyright file="ITemplate.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.Interfaces
{
    using System.Collections.Generic;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The ITemplate interface defines the necessary methods to interact with the Data Access Project
    /// </summary>
    public interface ITemplate
    {
        /// <summary>
        /// Gets the list of templates
        /// </summary>
        /// <returns>
        /// Returns an IList of templates
        /// </returns>
        IList<Template> GetTemplatesList();
    }
}

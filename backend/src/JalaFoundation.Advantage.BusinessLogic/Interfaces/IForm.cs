// <copyright file="IForm.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Interfaces
{
    using System.Collections.Generic;
    using Models;

    /// <summary>
    /// The IForm interface define the methods necessary to interact with the Data Access Project
    /// </summary>
    public interface IForm
    {
        /// <summary>
        /// Gets the Forms of the Form Repository
        /// </summary>
        /// <returns>
        /// Returns a IList with columns Id and Name of the FormRepository
        /// </returns>
        IList<Form> GetFormsList();

        /// <summary>
        /// Gets a Model of a form especified by his id
        /// </summary>
        /// <param name="id">
        /// The id from the searched Form
        /// </param>
        /// <returns>
        /// Return its Form Model  
        /// </returns>
        string GetFormModelById(int id);
    }
}

// <copyright file="ITag.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Interfaces
{
    using System.Collections.Generic;
    using Models;

    /// <summary>
    /// The ITag interface define the methods necessary to interact with the Data Access Project
    /// </summary>
    public interface ITag
    {
        /// <summary>
        /// Gets the Tags of the Tag Repository
        /// </summary>
        /// <returns>
        /// Returns a IList with columns Id and Name of the TagRepository
        /// </returns>
        IList<Tag> GetTagsList();
    }
}

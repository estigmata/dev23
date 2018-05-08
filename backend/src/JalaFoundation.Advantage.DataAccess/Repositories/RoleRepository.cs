// <copyright file="RoleRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.DataAccess.Repositories
{
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The RoleRepository class contains methods that interact with the database of the Role table.
    /// </summary>
    public class RoleRepository : IRoleRepository
    {
        /// <summary>
        /// Save a Model of a Role
        /// </summary>
        /// <param name="model">
        /// The model Role that be saved
        /// </param>
        /// <returns>
        /// Returns a model Role saved
        /// </returns>
        public Role Create(Role model)
        {
            using (var context = new AdvantageContext())
            {
                context.Roles.Add(model);
                context.SaveChanges();
                return model;
            }
        }

        /// <summary>
        /// Update a Model of a Role
        /// </summary>
        /// <param name="model">
        /// The model Role that be updated
        /// </param>
        /// <returns>
        /// Returns a model Role updated
        /// </returns>
        public Role Update(Role model)
        {
            using (var context = new AdvantageContext())
            {
                var updateModel = context.Roles.Find(model.Id);
                updateModel.Name = model.Name;
                updateModel.Url = model.Url;
                context.SaveChanges();
                return updateModel;
            }
        }
    }
}
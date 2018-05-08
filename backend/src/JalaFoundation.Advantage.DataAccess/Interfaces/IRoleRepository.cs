// <copyright file="IRoleRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.DataAccess.Interfaces
{
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The IRoleRepository interface implements methods to interact with Role at database
    /// </summary>
    public interface IRoleRepository : IRepository<Role>
    {
    }
}

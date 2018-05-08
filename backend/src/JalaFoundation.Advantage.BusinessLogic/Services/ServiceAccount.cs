// <copyright file="ServiceAccount.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Services
{    
    using JalaFoundation.Advantage.BusinessLogic.Exceptions;
    using JalaFoundation.Advantage.BusinessLogic.Interfaces;
    using JalaFoundation.Advantage.DataAccess;
    using JalaFoundation.Advantage.DataAccess.Extensions;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.DataAccess.Repositories;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The ServicesAccount class extends from SingletonBase Class and IAccount interface
    /// Implement methods to interact with the DataAccess Project
    /// </summary>
    public class ServiceAccount : SingletonBase<ServiceAccount>, IAccount
    {
        /// <summary>
        /// An attribute to interact with the Data Access Project
        /// </summary>
        private IRoleRepository roleRepository;

        /// <summary>
        /// An instance of Irepository
        /// </summary>
        private IUserRepository userRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceAccount"/> class.
        /// </summary>
        public ServiceAccount() : base()
        {
            this.userRepository = RepositoryFactory.GetUserRepository();
            this.roleRepository = RepositoryFactory.GetRoleRepository();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceAccount"/> class.
        /// </summary>
        /// <param name="userRepository">
        /// Receives the instance of IUserRespository
        /// </param>
        /// <param name="roleRepository">
        /// Recieves the instance of IRoleRepository
        /// </param>
        public ServiceAccount(IUserRepository userRepository, IRoleRepository roleRepository) : base()
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
        }

        /// <summary>
        /// Gets the Role of an user especified by its email and password
        /// </summary>
        /// <param name="email">
        /// The email of the searched user
        /// </param>
        /// <param name="password">
        /// The password of the searched user
        /// </param>
        /// <returns>
        /// The role of the user that matches the email and password
        /// </returns>
        public Role GetRole(string email, string password)
        {
            var roleId = this.userRepository.GetPropertyWhere(u => u.Email == email && u.Password == password, u => u.RoleId);

            var role = this.roleRepository.GetPropertyWhere(u => u.Id == roleId, u => u);

            if (role == null)
            {
                throw new NullRoleException();
            }

            return role;
        }

        /// <summary>
        /// Gets the UserID of an user specified by his email
        /// </summary>
        /// <param name="email">
        /// The email from the searched user
        /// </param>
        /// <returns>
        /// Returns the searched UserID
        /// </returns>
        public long GetUserIdByEmail(string email)
        {
            var result = this.userRepository.GetPropertyWhere(u => u.Email == email, u => u.Id);
            return result;
        }

        /// <summary>
        /// Set the repository instance of a user used for this class
        /// </summary>
        /// <param name="userRepository">
        /// An instance of IUserRepository to be set
        /// </param>
        public void SetUserRepository(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        /// <summary>
        /// Set the repository instance of a role used for this class
        /// </summary>
        /// <param name="roleRepository">
        /// An instance of IRoleRepository to be set
        /// </param>
        public void SetRoleRepository(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }
    }
}

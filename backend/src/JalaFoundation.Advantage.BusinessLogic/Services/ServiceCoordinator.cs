// <copyright file="ServiceCoordinator.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.Services
{
    using System.Collections.Generic;
    using JalaFoundation.Advantage.BusinessLogic.Exceptions;
    using JalaFoundation.Advantage.BusinessLogic.Interfaces;
    using JalaFoundation.Advantage.DataAccess;
    using JalaFoundation.Advantage.DataAccess.Extensions;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.DataAccess.Repositories;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The ServiceCoordination class extends from SingletonBase Class and ICoordinator interface
    /// Implement methods to interact with the DataAccess Project
    /// </summary>
    public class ServiceCoordinator : SingletonBase<ServiceCoordinator>, ICoordinator
    {
        /// <summary>
        /// An instance of Irepository
        /// </summary>
        private IPromoterRepository promoterRepository;

        /// <summary>
        /// An instance of Irepository
        /// </summary>
        private IContactRepository contactRepository;
        
        /// <summary>
        /// Prevents a default instance of the <see cref="ServiceCoordinator"/> class from being created.
        /// </summary>
        private ServiceCoordinator() : base()
        {
            this.promoterRepository = RepositoryFactory.GetPromoterRepository();
            this.contactRepository = RepositoryFactory.GetContactRepository();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCoordinator"/> class.
        /// </summary>
        /// <param name="promoterRepository">
        /// Receives the instance of IPromoterRepository
        /// </param>
        /// <param name="contactRepository">
        /// Receives the instance of IContactRepository
        /// </param>
        private ServiceCoordinator(IPromoterRepository promoterRepository, IContactRepository contactRepository) : base()
        {
            this.promoterRepository = promoterRepository;
            this.contactRepository = contactRepository;
        }

        /// <summary>
        /// Gets the Promoters List of the PromotersRepository
        /// </summary>
        /// <returns>
        /// Returns a IList of the PromotersRepository
        /// </returns>
        public IList<Promoter> GetPromotersList()
        {
            var results = this.promoterRepository.GetPromotersList();

            if (results == null)
            {
                throw new NullListPromotersException();
            }

            return results;
        }

        /// <summary>
        /// Gets the Contact of an Promoter especified by his contactID
        /// </summary>
        /// <param name ="id">
        /// The id from the searched contact
        /// </param>
        /// <returns>
        /// Returns a Contact of the ContactRepository
        /// </returns>
        public Contact GetContactById(long id)
        {
            var result = this.contactRepository.GetPropertyWhere(contact => contact.Id == id, contact => contact);

            if (result == null)
            {
                throw new NullContactException();
            }

            return result;  
        }

        /// <summary>
        /// Set the repository instance of a promoter used for this class
        /// </summary>
        /// <param name="promoterRepository">
        /// An instance of IPromoterRepository to be set
        /// </param>
        public void SetPromoterRepository(IPromoterRepository promoterRepository)
        {
            this.promoterRepository = promoterRepository;
        }

        /// <summary>
        /// Set the repository instance of a contact used for this class
        /// </summary>
        /// <param name="contactRepository">
        /// An instance of IContactRepository to be set
        /// </param>
        public void SetContactRepository(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }
    }
}

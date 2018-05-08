// <copyright file="ServicePromotion.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.Services
{
    using System;
    using JalaFoundation.Advantage.BusinessLogic.Exceptions;
    using JalaFoundation.Advantage.BusinessLogic.Interfaces;
    using JalaFoundation.Advantage.DataAccess;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.DataAccess.Repositories;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The ServicePromotion class extends from SingletonBase Class and IPromotion interface
    /// Implement methods to interact with the DataAccess Project
    /// </summary>
    public class ServicePromotion : SingletonBase<ServicePromotion>, IPromotion
    {
        /// <summary>
        /// An instance of IRepository
        /// </summary>
        private IBenefitRepository benefitRepository;
        
        /// <summary>
        /// Prevents a default instance of the <see cref="ServicePromotion"/> class from being created.
        /// </summary>
        private ServicePromotion() : base()
        {
            this.benefitRepository = RepositoryFactory.GetBenefitRepository();
        }

        /// <summary>
        /// Initializes a new instance of the  <see cref="ServicePromotion"/> class.
        /// </summary>
        /// <param name="benefitRepository">
        /// Receives the instance of IBenefitRepository
        /// </param>
        private ServicePromotion(IBenefitRepository benefitRepository) : base()
        {
            this.benefitRepository = benefitRepository;
        }

        /// <summary>
        /// Calls to repository to save a Benefit
        /// </summary>
        /// <param name="model">
        /// A model of a benefit to be saved
        /// </param>
        /// <returns>
        /// Returns true if it have been created and false on fail
        /// </returns>
        public bool CreateBenefit(Benefit model)
        {
            model.CreationDate = DateTime.Now;
            var result = this.benefitRepository.Create(model);

            if (result.Id > 0)
            {
                return true;
            }

            throw new BenefitNotCreatedException();
        }

        /// <summary>
        /// Set the repository instance of a benefit used for this class
        /// </summary>
        /// <param name="benefitRepository">
        /// An instance of IBenefitRepository to be set
        /// </param>
        public void SetBenefitRepository(IBenefitRepository benefitRepository)
        {
            this.benefitRepository = benefitRepository;
        }
    }
}

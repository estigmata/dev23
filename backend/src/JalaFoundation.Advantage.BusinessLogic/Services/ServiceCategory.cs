// <copyright file="ServiceCategory.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.Services
{
    using System.Collections.Generic;
    using JalaFoundation.Advantage.BusinessLogic.DTO;
    using JalaFoundation.Advantage.BusinessLogic.Exceptions;
    using JalaFoundation.Advantage.BusinessLogic.Interfaces;
    using JalaFoundation.Advantage.DataAccess;
    using JalaFoundation.Advantage.DataAccess.Extensions;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.DataAccess.Repositories;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The ServiceCategory class extends from SingletonBase Class and ICategory interface
    /// Implement methods to interact with the DataAccess Project
    /// </summary>
    public class ServiceCategory : SingletonBase<ServiceCategory>, ICategory
    {
        /// <summary>
        /// An instance of CategoryRepository
        /// </summary>
        private ICategoryRepository categoryRepository;

        /// <summary>
        /// An instance of ServiceAdvantage
        /// </summary>
        private ServiceAdvantage advantageService;

        /// <summary>
        /// Prevents a default instance of the <see cref="ServiceCategory"/> class from being created.
        /// </summary>
        private ServiceCategory() : base()
        {
            this.categoryRepository = RepositoryFactory.GetCategoryRepository();
            this.advantageService = SingletonBase<ServiceAdvantage>.GetInstance();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCategory"/> class.
        /// </summary>
        /// <param name="categoryRepository">
        /// Receives the instance of ICategoryRepository
        /// </param>
        private ServiceCategory(ICategoryRepository categoryRepository) : base()
        {
            this.categoryRepository = categoryRepository;
        }

        /// <summary>
        /// Gets the Categories List of the Form Repository
        /// </summary>
        /// <returns>
        /// Returns a IList  with columns Id and Name of the CategoryRepository
        /// </returns>
        public IList<Category> GetCategoriesList()
        {
            var result = this.categoryRepository.GetSelectedAs(f => f);

            if (result == null)
            {
                throw new NullListCategoryException();
            }

            return result;
        }

        /// <summary>
        /// Gets the CategoryDTO list 
        /// </summary>
        /// <returns>
        /// Returns a IList of categoryDTO
        /// </returns>
        public IList<CategoryDTO> GetCategoryListDetail()
        {
            var categories = this.categoryRepository.GetSelectedAs(f => f);

            List<CategoryDTO> categoriesList = new List<CategoryDTO>();

            foreach (var category in categories)
            {
                CategoryDTO categoryDTO = new CategoryDTO()
                {
                    Id = category.Id,
                    Name = category.Name,
                    Icon = category.Icon,
                    NewBenefitsQuantity = this.advantageService.CountNewBenefits(category.Id)
                };

                categoriesList.Add(categoryDTO);
            }

            return categoriesList;
        }

        /// <summary>
        /// Set the repository instance of a category used for this class
        /// </summary>
        /// <param name="categoryRepository">
        /// An instance of ICategoryRepository to be set
        /// </param>
        public void SetCategoryRepository(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
    }
}

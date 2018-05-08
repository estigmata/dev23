// <copyright file="ServiceTemplate.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using JalaFoundation.Advantage.BusinessLogic.Exceptions;
    using JalaFoundation.Advantage.BusinessLogic.Interfaces;
    using JalaFoundation.Advantage.DataAccess;
    using JalaFoundation.Advantage.DataAccess.Extensions;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.DataAccess.Repositories;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The ServiceTemplate class implements the methods to interact with the DataAccess Project
    /// </summary>
    public class ServiceTemplate : SingletonBase<ServiceTemplate>, ITemplate
    {
        /// <summary>
        /// An instance of TemplateRepository
        /// </summary>
        private ITemplateRepository templateRepository;

        /// <summary>
        /// Prevents a default instance of the <see cref="ServiceTemplate"/> class from being created.
        /// </summary>
        private ServiceTemplate() : base()
        {
            this.templateRepository = RepositoryFactory.GetTemplateRepository();
        }

        /// <summary>
        /// Initializes a new instance of the  <see cref="ServiceTemplate"/> class.
        /// </summary>
        /// <param name="templateRepository">
        /// Receives the instance of ITemplateRepository
        /// </param>
        private ServiceTemplate(ITemplateRepository templateRepository) : base()
        {
            this.templateRepository = templateRepository;
        }

        /// <summary>
        /// Gets the list of Templates
        /// </summary>
        /// <returns>
        /// Returns an IList of Templates
        /// </returns>
        public IList<Template> GetTemplatesList()
        {
            var templates = this.templateRepository.GetAll();

            if (!templates.Any())
            {
                throw new EmptyTemplatesListException();
            }

            return templates;
        }

        /// <summary>
        /// Set the repository instance of a template used for this class
        /// </summary>
        /// <param name="templateRepository">
        /// An instance of ITemplateRepository to be set
        /// </param>
        public void SetTemplateRepository(ITemplateRepository templateRepository)
        {
            this.templateRepository = templateRepository;
        }
    }
}

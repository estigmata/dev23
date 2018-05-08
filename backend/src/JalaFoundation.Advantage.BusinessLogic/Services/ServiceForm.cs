// <copyright file="ServiceForm.cs" company="Jala Foundation">
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
    /// The ServiceForm class extends from SingletonBase Class and IForm interface
    /// Implement methods to interact with the DataAccess Project
    /// </summary>
    public class ServiceForm : SingletonBase<ServiceForm>, IForm
    {
        /// <summary>
        /// An instance of IRepository
        /// </summary>
        private IFormRepository formRepository;

        /// <summary>
        /// Prevents a default instance of the <see cref="ServiceForm"/> class from being created.
        /// </summary>
        private ServiceForm() : base()
        {
            this.formRepository = RepositoryFactory.GetFormRepository();
        }

        /// <summary>
        /// Initializes a new instance of the  <see cref="ServiceForm"/> class.
        /// </summary>
        /// <param name="formRepository">
        /// Receives the instance of IRepository
        /// </param>
        private ServiceForm(FormRepository formRepository) : base()
        {
            this.formRepository = formRepository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceForm"/> class.
        /// </summary>
        /// <param name="formRepository">
        /// Receives the instance of IFormRepository
        /// </param>
        private ServiceForm(IFormRepository formRepository) : base()
        {
            this.formRepository = formRepository;
        }

        /// <summary>
        /// Gets a Model of a form especified by his id
        /// </summary>
        /// <param name="id">
        /// The id from the searched Form
        /// </param>
        /// <returns>
        /// Return its Form Model
        /// </returns>
        public string GetFormModelById(int id)
        {
            var result = this.formRepository.GetPropertyWhere(u => u.Id == id, u => u.Model);

            if (result == null)
            {
                throw new NullFormException();
            }

            return result;
        }

        /// <summary>
        /// Gets the Forms List of the Form Repository
        /// </summary>
        /// <returns>
        /// Returns a IList  with columns Id and Name of the FormRepository
        /// </returns>
        public IList<Form> GetFormsList()
        {
            var result = this.formRepository.GetSelectedAs(f => f);

            if (result == null)
            {
                throw new NullFormException();
            }

            return result;
        }

        /// <summary>
        /// Set the repository instance of a form used for this class
        /// </summary>
        /// <param name="formRepository">
        /// An instance of IFormRepository to be set
        /// </param>
        public void SetFormRepository(IFormRepository formRepository)
        {
            this.formRepository = formRepository;
        }
    }
}

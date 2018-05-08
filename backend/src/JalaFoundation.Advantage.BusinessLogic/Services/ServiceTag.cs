// <copyright file="ServiceTag.cs" company="Jala Foundation">
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
    /// The ServiceTag class extends from SingletonBase Class and ITag interface
    /// Implement methods to interact with the DataAccess Project
    /// </summary>
    public class ServiceTag : SingletonBase<ServiceTag>, ITag
    {
        /// <summary>
        /// An instance of tagRepository
        /// </summary>
        private ITagRepository tagRepository;

        /// <summary>
        /// An instance of promoterTagRepository
        /// </summary>
        private IPromoterTagRepository promoterTagRepository;

        /// <summary>
        /// Prevents a default instance of the <see cref="ServiceTag"/> class from being created.
        /// Init an instance of TagRepository and assigns it to tagRepository.
        /// </summary>
        private ServiceTag() : base()
        {
            this.tagRepository = RepositoryFactory.GetTagRepository();
            this.promoterTagRepository = RepositoryFactory.GetPromoterTagRepository();
        }

        /// <summary>
        /// Initializes a new instance of the  <see cref="ServiceTag"/> class.
        /// </summary>
        /// <param name="promoterTagRepository">
        /// Receives the instance of IPromoterTagRepository
        /// </param>
        private ServiceTag(IPromoterTagRepository promoterTagRepository) : base()
        {
            this.promoterTagRepository = promoterTagRepository;
        }

        /// <summary>
        /// Gets the Tags List of the Tag Repository
        /// </summary>
        /// <returns>
        /// Returns a IList  with columns Id and Name of the TagRepository
        /// </returns>
        public IList<Tag> GetTagsList()
        {
            var result = this.tagRepository.GetSelectedAs(f => f);

            if (result == null)
            {
                throw new NullListTagsException();
            }

            return result;
        }

        /// <summary>
        /// Delete the tags from a specific promoter
        /// </summary>
        /// <param name="promoterId">
        /// The promoterId is the id of a specific Promoter
        /// </param>
        /// <returns>
        /// Return a bool if all is correct 
        /// </returns>
        public bool DeleteTags(int promoterId)
        {
            return this.promoterTagRepository.DeleteTagsByPromoter(promoterId);
        }

        /// <summary>
        /// Set the repository instance of a tag used for this class
        /// </summary>
        /// <param name="promoterTagRepository">
        /// An instance of IPromoterTagRepository to be set
        /// </param>
        public void SetPromoterTagRepository(IPromoterTagRepository promoterTagRepository)
        {
            this.promoterTagRepository = promoterTagRepository;
        }
    }
}

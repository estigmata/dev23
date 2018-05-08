// <copyright file="PromoterRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.DataAccess.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.Models;  

    /// <summary>
    /// The PromoterRepository class contains methods that interact with the database of the Promoter table.
    /// </summary>
    public class PromoterRepository : IRepository<Promoter>, IPromoterRepository
    {
        /// <summary>
        /// Save a Model of a Promoter
        /// </summary>
        /// <param name="model">
        /// The model Promoter that be saved
        /// </param>
        /// <returns>
        /// Returns a model Promoter saved
        /// </returns>
        public Promoter Create(Promoter model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update a Model of a Promoter
        /// </summary>
        /// <param name="model">
        /// The model Promoter that be updated
        /// </param>
        /// <returns>
        /// Returns a model Promoter updated
        /// </returns>
        public Promoter Update(Promoter model)
        {
            int notExist = -1;
            var resultPromoter = new Promoter();
            using (var context = new AdvantageContext())
            {
                var updateModel = context.Promoters.Find(model.Id);
                updateModel.Name = model.Name;
                updateModel.CategoryID = model.CategoryID;
                foreach (var tag in model.PromoterTag)
                {
                    var tagId = tag.TagID;
                    if (tagId == notExist)
                    {
                        var newTag = RepositoryFactory.GetTagRepository().Create(new Tag() { Name = tag.Tag.Name });
                        tagId = newTag.Id;
                    }

                    var addTag = RepositoryFactory.GetPromoterTagRepository().Create(new PromoterTag() { PromoterID = model.Id, TagID = tagId });
                }

                context.SaveChanges();
                resultPromoter.Image = RepositoryFactory.GetImageRepository().Update(model.Image);
                resultPromoter.Contact = RepositoryFactory.GetContactRepository().Update(model.Contact);
                resultPromoter.Name = updateModel.Name;
                resultPromoter.CategoryID = updateModel.CategoryID;
            }

            return resultPromoter;
        }

        /// <summary>
        /// Return an Promoter from the database using his specific id as parameter
        /// </summary>
        /// <param name="id">
        /// The id represents the id property from the searched Promoter
        /// </param>
        /// <returns>return an Promoter with the specified id</returns>
        public Promoter Get(int id)
        {
            using (var context = new AdvantageContext())
            {
                return context.Promoters.Find(id);
            }
        }

        /// <summary>
        /// This method obtain the list of Promoters that exist in the database
        /// </summary>
        /// <returns>
        /// A list of promoters
        /// </returns>
        public IList<Promoter> GetPromotersList()
        {
            using (var context = new AdvantageContext())
            {
                return context.Promoters
                .Include("Stores")
                .Include("Contact")
                .ToList();
            }
        }
    }
}

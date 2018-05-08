// <copyright file="PromoterTagRepository.cs" company="Jala Foundation">
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
    /// The PromoterTagRepository class contains methods that interact with the database of the PromoterTag table.
    /// </summary>
    public class PromoterTagRepository : IPromoterTagRepository, IRepository<PromoterTag>
    {
        /// <summary>
        /// Save a Model of a PromoterTag
        /// </summary>
        /// <param name="model">
        /// The model PromoterTag that be saved
        /// </param>
        /// <returns>
        /// Returns a model PromoterTag saved
        /// </returns>
        public PromoterTag Create(PromoterTag model)
        {
            using (var context = new AdvantageContext())
            {
                var promoterTag = context.PromoterTags.Add(model);
                context.SaveChanges();
                return promoterTag;
            }
        }

        /// <summary>
        /// Delete tags from a promoter
        /// </summary>
        /// <param name="promoterId">
        /// The promoterId is the id of a specific Promoter
        /// </param>
        /// <returns>
        /// Returns true if the the tags from the promoter is deleted
        /// </returns>
        public bool DeleteTagsByPromoter(int promoterId)
        {
            using (var context = new AdvantageContext())
            {
                var promoterTags = this.GetTagsByPromoter(promoterId);
                foreach (var promoterTag in promoterTags)
                {
                    context.PromoterTags.Attach(promoterTag);
                    context.PromoterTags.Remove(promoterTag);
                }

                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Get a list of tags of a specific Promoter
        /// </summary>
        /// <param name="promoterId">
        /// The promoterId is the id of a specific Promoter
        /// </param>
        /// <returns>
        /// Return a List of Tags of a specific Promoter 
        /// </returns>
        public List<PromoterTag> GetTagsByPromoter(int promoterId)
        {
            using (var context = new AdvantageContext())
            {
                context.Configuration.ProxyCreationEnabled = false;
                return context.PromoterTags.Include("Tag").Where(b => b.PromoterID == promoterId).ToList();
            }
        }

        /// <summary>
        /// Update a specific PromoterTag model
        /// </summary>
        /// <param name="model">
        /// PromoterTag to be updated at the database
        /// </param>
        /// <returns>
        /// Returns the updated and saved PromoterTag 
        /// </returns>
        public PromoterTag Update(PromoterTag model)
        {
            using (var context = new AdvantageContext())
            {
                var updateModel = context.PromoterTags.Find(model.Id);
                updateModel.PromoterID = model.PromoterID;
                updateModel.TagID = model.TagID;
                context.SaveChanges();
                return updateModel;
            }
        }
    }
}

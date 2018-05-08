// <copyright file="BenefitRepository.cs" company="Jala Foundation">
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
    /// The BenefitRepository class implements methods from IRepository
    /// </summary>
    public class BenefitRepository : IBenefitRepository
    {
        /// <summary>
        /// Create a new Benefit model
        /// </summary>
        /// <param name="model">
        /// Benefit to be added at the database
        /// </param>
        /// <returns>
        /// Returns the saved Benefit with his respective Id
        /// </returns>
        public Benefit Create(Benefit model)
        {
            using (var context = new AdvantageContext())
            {
                context.Benefits.Add(model);
                context.SaveChanges();
                return model;
            }
        }

        /// <summary>
        /// Update a model
        /// </summary>
        /// <param name="model">
        /// The model to be updated
        /// </param>
        /// <returns>
        /// The model updated
        /// </returns>
        public Benefit Update(Benefit model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return an Benefit from the database using his specific id as parameter
        /// </summary>
        /// <param name="id">
        /// The id represents the id property from the searched Benefit
        /// </param>
        /// <returns>return an Benefit with the specified id</returns>
        public Benefit Get(int id)
        {
            using (var context = new AdvantageContext())
            {
                context.Configuration.ProxyCreationEnabled = false;
                return context.Benefits
                .Include("Promoter")
                .Include("Promoter.Image")
                .Include("Promoter.Category")
                .Include("Promoter.Stores")
                .Include("Promoter.Contact")
                .Include("Promoter.PromoterTag.Tag")
                .Include("Banner")
                .FirstOrDefault(b => b.Id == id); 
            }
        }

        /// <summary>
        /// Update a Model of a Benefit
        /// </summary>
        /// /// <param name="benefitId">
        /// The id of the benefit to be updated
        /// </param>
        /// <param name="newBenefit">
        /// The benefit with the new information
        /// </param>
        /// <returns>
        /// True if the benefit was updated sucesfully or False if not
        /// </returns>
        public bool Update(int benefitId, Benefit newBenefit)
        {
            using (var context = new AdvantageContext())
            {
                var benefit = context.Benefits.Find(benefitId);

                if (benefit == null)
                {
                    throw new ArgumentException("the benefit doesn't exist in database");
                }

                benefit.Name = newBenefit.Name;
                benefit.Description = newBenefit.Description;
                benefit.Status = newBenefit.Status;
                benefit.MainText = newBenefit.MainText;
                benefit.Banner.Model = newBenefit.Banner.Model;

                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Get the list of all benefits
        /// </summary>
        /// <returns>
        /// A list of benefits
        /// </returns>
        public IList<Benefit> GetAllWithPromoters()
        {
            using (var context = new AdvantageContext())
            {
                return context.Benefits
                    .Include("Promoter.Image")
                    .Include("Promoter.PromoterTag.Tag")
                    .Include("Promoter.Category")
                    .ToList();
            }
        }

        /// <summary>
        /// Get the list of benefits belongs to categoryId
        /// </summary>
        /// <param name="categoryId">
        /// This is a specific category
        /// </param>
        /// <returns>
        /// Returns a list of Benefits 
        /// </returns>
        public IList<Benefit> GetBenefitsByCategory(int categoryId)
        {
            using (var context = new AdvantageContext())
            {
                return context.Benefits
                    .Include("Promoter.Category")
                    .Where(p => p.Promoter.CategoryID == categoryId)
                    .ToList();
            }
        }

        /// <summary>
        /// Get the list of benefits belongs to promotersId
        /// </summary>
        /// <param name="promoterId">
        /// This is a specific Promoter
        /// </param>
        /// <returns>Returns a list of Benefits</returns>
        public IList<Benefit> GetBenefitsByPromoter(int promoterId)
        {
            using (var context = new AdvantageContext())
            {
                return context.Benefits
                    .Where(p => p.PromoterId == promoterId)
                    .ToList();
            }
        }

        /// <summary>
        /// Delete a specific benefit by id in Benefits table
        /// </summary>
        /// <param name="id">
        /// The id of the benefit
        /// </param>
        /// <returns>
        /// A true if the benefit was deleted and false if the operation of delete is failed
        /// </returns>
        public bool Delete(int id)
        {
            using (var context = new AdvantageContext())
            {
                var benefit = context.Benefits.Find(id);
                if (benefit == null)
                {
                    return false;
                }

                context.Benefits.Attach(benefit);
                context.Benefits.Remove(benefit);
                context.SaveChanges();
                return true;
            }
        }
    }
}

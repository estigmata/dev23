// <copyright file="RepositoryFactory.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess
{
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.DataAccess.Repositories;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The RepositoryFactory class can create and return the different Repository instances
    /// </summary>
    public class RepositoryFactory
    {
        /// <summary>
        /// Get an instance of UserRepository
        /// </summary>
        /// <returns>
        /// An instance of UserRepository
        /// </returns>
        public static UserRepository GetUserRepository()
        {
            return new UserRepository();
        }

        /// <summary>
        /// Get an instance of FormRepository
        /// </summary>
        /// <returns>
        /// An instance of FormRepository
        /// </returns>
        public static FormRepository GetFormRepository()
        {
            return new FormRepository();
        }

        /// <summary>
        /// Get an instance of BenefitRepository
        /// </summary>
        /// <returns>
        /// An instance of BenefitRepository
        /// </returns>
        public static BenefitRepository GetBenefitRepository()
        {
            return new BenefitRepository();
        }

        /// <summary>
        /// Get an instance of PromoterRepository
        /// </summary>
        /// <returns>
        /// An instance of PromoterRepository
        /// </returns>
        public static PromoterRepository GetPromoterRepository()
        {
            return new PromoterRepository();
        }

        /// <summary>
        /// Get an instance of ImageRepository
        /// </summary>
        /// <returns>
        /// An instance of ImageRepository
        /// </returns>
        public static ImageRepository GetImageRepository()
        {
            return new ImageRepository();
        }

        /// <summary>
        /// Get an instance of CategoryRepository
        /// </summary>
        /// <returns>
        /// An instance of CategoryRepository
        /// </returns>
        public static CategoryRepository GetCategoryRepository()
        {
            return new CategoryRepository();
        }

        /// <summary>
        /// Get an instance of ContactRepository
        /// </summary>
        /// <returns>
        /// An instance of contactRepository
        /// </returns>
        public static ContactRepository GetContactRepository()
        {
            return new ContactRepository();
        }

        /// <summary>
        /// Get an instance of StoreRepository
        /// </summary>
        /// <returns>
        /// An instance of storeRepository
        /// </returns>
        public static StoreRepository GetStoreRepository()
        {
            return new StoreRepository();
        }

        /// <summary>
        /// Get an instance of BannerRepository
        /// </summary>
        /// <returns>
        /// An instance of BannerRepository
        /// </returns>
        public static BannerRepository GetBannerRepository()
        {
            return new BannerRepository();
        }

        /// <summary>
        /// Get an instance of TagRepository
        /// </summary>
        /// <returns>
        /// An instance of TagRepository
        /// </returns>
        public static TagRepository GetTagRepository()
        {
            return new TagRepository();
        }

        /// <summary>
        /// Get an instance of TemplateRepository
        /// </summary>
        /// <returns>
        /// An instance of TemplateRepository
        /// </returns>
        public static TemplateRepository GetTemplateRepository()
        {
            return new TemplateRepository();
        }

        /// <summary>
        /// Get an instance of PromoterTagRepository
        /// </summary>
        /// <returns>
        /// An instance of PromoterTagRepository
        /// </returns>
        public static PromoterTagRepository GetPromoterTagRepository()
        {
            return new PromoterTagRepository();
        }

        /// <summary>
        /// Get an instance of ScheduleRepository
        /// </summary>
        /// <returns>
        /// An instance of ScheduleRepository
        /// </returns>
        public static ScheduleRepository GetScheduleRepository()
        {
            return new ScheduleRepository();
        }

        /// <summary>
        /// Get an instance of RoleRepository
        /// </summary>
        /// <returns>
        /// An instance of RoleRepository
        /// </returns>
        public static RoleRepository GetRoleRepository()
        {
            return new RoleRepository();
        }

        /// <summary>
        /// Get an instance of PromoterScheduleRepository
        /// </summary>
        /// <returns>
        /// An instance of PromoterScheduleRepository
        /// </returns>
        public static PromoterScheduleRepository GetPromoterScheduleRepository()
        {
            return new PromoterScheduleRepository();
        }
    }
}

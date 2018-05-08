// <copyright file="ServicePromoter.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.Services
{
    using System;
    using System.Collections.Generic;
    using JalaFoundation.Advantage.BusinessLogic.Exceptions;
    using JalaFoundation.Advantage.BusinessLogic.Interfaces;
    using JalaFoundation.Advantage.DataAccess;
    using JalaFoundation.Advantage.DataAccess.Extensions;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.DataAccess.Repositories;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The ServicePromoter class extends from SingletonBase Class and IPromoter interface
    /// Implement methods to interact with the DataAccess Project
    /// </summary>
    public class ServicePromoter : SingletonBase<ServicePromoter>, IPromoter
    {
        /// <summary>
        /// An attribute to interact with the Data Access Project
        /// </summary>
        private IPromoterScheduleRepository promoterScheduleRepository;

        /// <summary>
        /// An instance of IRepository
        /// </summary>
        private IPromoterRepository promoterRepository;

        /// <summary>
        /// An instance of IRepository that returns the Category repository
        /// </summary>
        private ICategoryRepository categoryRepository;

        /// <summary>
        /// An instance of IRepository that returns the Contact repository
        /// </summary>
        private IContactRepository contactRepository;

        /// <summary>
        /// An instance of IRepository that returns the Image repository
        /// </summary>
        private IImageRepository imageRepository;

        /// <summary>
        /// An attribute to interact with the Data Access Project
        /// </summary>
        private IStoreRepository storeRepository;

        /// <summary>
        /// An attribute to interact with the Data Access Project
        /// </summary>
        private IPromoterTagRepository promoterTagRepository;

        /// <summary>
        /// An attribute to interact with the Data Access Project
        /// </summary>
        private IScheduleRepository scheduleRepository;
        
        /// <summary>
        /// Prevents a default instance of the <see cref="ServicePromoter"/> class from being created.
        /// Init an instance of PromoterRepository and assigns it to promoterRepository.
        /// Init an instance of CategoryRepository and assigns it to promoterRepository.
        /// Init an instance of ContactRepository and assigns it to promoterRepository.
        /// Init an instance of ImageRepository and assigns it to promoterRepository.
        /// Init an instance of StoreRepository and assigns it to storeRepository.
        /// Init an instance of ScheduleRepository and assigns it to scheduleRepository.
        /// Init an instance of PromoterScheduleRepository and assigns it to promoterScheduleRepository.
        /// </summary>
        private ServicePromoter() : base()
        {
            this.promoterRepository = RepositoryFactory.GetPromoterRepository();
            this.categoryRepository = RepositoryFactory.GetCategoryRepository();
            this.contactRepository = RepositoryFactory.GetContactRepository();
            this.imageRepository = RepositoryFactory.GetImageRepository();
            this.storeRepository = RepositoryFactory.GetStoreRepository();
            this.promoterTagRepository = RepositoryFactory.GetPromoterTagRepository();
            this.scheduleRepository = RepositoryFactory.GetScheduleRepository();
            this.promoterScheduleRepository = RepositoryFactory.GetPromoterScheduleRepository();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePromoter"/> class.
        /// </summary>
        /// <param name="promoterScheduleRepository">
        /// Receives the instance of IPromoterScheduleRepository
        /// </param>
        /// <param name="promoterRepository">
        /// Receives the instance of IPromoterRepository
        /// </param>
        /// <param name="categoryRepository">
        /// Receives the instance of ICategoryRepository
        /// </param>
        /// <param name="contactRepository">
        /// Receives the instance of IContactRepository
        /// </param>
        /// <param name="imageRepository">
        /// Receives the instance of IImageRepository
        /// </param>
        /// <param name="storeRepository">
        /// Receives the instance of IStoreRepository
        /// </param>
        /// <param name="promoterTagRepository">
        /// Receives the instance of IPromoterTagRepository
        /// </param>
        /// <param name="scheduleRepository">
        /// Receives the instance of IScheduleRepository
        /// </param>
        private ServicePromoter(IPromoterScheduleRepository promoterScheduleRepository, IPromoterRepository promoterRepository, ICategoryRepository categoryRepository, IContactRepository contactRepository, IImageRepository imageRepository, IStoreRepository storeRepository, IPromoterTagRepository promoterTagRepository, IScheduleRepository scheduleRepository) : base()
        {
            this.promoterScheduleRepository = promoterScheduleRepository;
            this.promoterRepository = promoterRepository;
            this.categoryRepository = categoryRepository;
            this.contactRepository = contactRepository;
            this.imageRepository = imageRepository;
            this.storeRepository = storeRepository;
            this.promoterTagRepository = promoterTagRepository;
            this.scheduleRepository = scheduleRepository;
        }

        /// <summary>
        /// Send a object Promoter to Data Access Project
        /// </summary>
        /// <param name="promoter">
        /// The promoter is a Object 
        /// </param>
        /// <returns>
        /// Return its Promoter Model  
        /// </returns>
        public Promoter UpdatePromoter(Promoter promoter)
        {
            var updatedPromoter = this.promoterRepository.Update(promoter);
            return updatedPromoter;
        }

        /// <summary>
        /// Get a object Promoter by UserId
        /// </summary>
        /// <param name="userId">
        /// The promoter is a Object 
        /// </param>
        /// <returns>
        /// Return its Promoter Model  
        /// </returns>
        public Promoter GetPromoter(int userId)
        {
            Promoter promoter = this.promoterRepository.GetPropertyWhere(u => u.UserID == userId, u => u);
            promoter.Contact = this.GetContact(promoter.ContactID);
            promoter.Category = this.GetCategory(promoter.CategoryID);
            promoter.Image = this.GetImage(promoter.ImageID);
            promoter.PromoterTag = this.GetTags(promoter.Id);

            return promoter;
        }

        /// <summary>
        /// Get a List of Tags by id of promoter
        /// </summary>
        /// <param name="promoterId">
        /// The promoterId is the id of a specific Promoter
        /// </param>
        /// <returns>
        /// Return a List of Tags of a specific Promoter 
        /// </returns>
        public List<PromoterTag> GetTags(int promoterId)
        {
            var tags = this.promoterTagRepository.GetTagsByPromoter(promoterId);
            return tags;
        }

        /// <summary>
        /// Get a object Contact by id
        /// </summary>
        /// <param name="contactId">
        /// The Contact is a Object 
        /// </param>
        /// <returns>
        /// Return its Contact Model  
        /// </returns>
        public Contact GetContact(int contactId)
        {
            var contact = this.contactRepository.GetPropertyWhere(u => u.Id == contactId, u => u);
            return contact;
        }

        /// <summary>
        /// Get a object Category by id
        /// </summary>
        /// <param name="categoryId">
        /// The Category is a Object 
        /// </param>
        /// <returns>
        /// Return its Category Model  
        /// </returns>
        public Category GetCategory(int categoryId)
        {
            var category = this.categoryRepository.GetPropertyWhere(u => u.Id == categoryId, u => u);
            return category;
        }

        /// <summary>
        /// Get a object Image by id
        /// </summary>
        /// <param name="imageId">
        /// The Image is a Object 
        /// </param>
        /// <returns>
        /// Return its Image Model  
        /// </returns>
        public Image GetImage(int imageId)
        {
            var image = this.imageRepository.GetPropertyWhere(u => u.Id == imageId, u => u);
            return image;
        }

        /// <summary>
        /// Add a new store to the specified promoter 
        /// </summary>
        /// <param name="promoterId">This is the PromoterId of the Promoter</param>
        /// <param name="store">This is a new store that will be added to the Promoter</param>
        /// <returns>return a new Store </returns>
        public Store AddStore(int promoterId, Store store)
        {
            var promoter = this.promoterRepository.GetByProperty(u => u.Id == promoterId);

            if (promoter == null)
            {
                throw new NullPromoterException();
            }
            else
            {
                store.PromoterID = promoterId;
                var newStore = this.storeRepository.Create(store);
                return newStore;
            }
        }

        /// <summary>
        /// Get a list of stores for the specified promoterId
        /// </summary>
        /// <param name="promoterId">This is the PromoterId of the Promoter</param>
        /// <returns>return a List of stores for the specific promoter</returns>
        public IList<Store> GetStores(int promoterId)
        {
            var promoter = this.promoterRepository
                .GetByProperty(u => u.Id == promoterId);

            if (promoter == null)
            {
                throw new NullPromoterException();
            }
           
            var storesList = this.storeRepository
                .GetListWhere(u => u, u => u.PromoterID == promoterId);

            return storesList;            
        }

        /// <summary>
        /// Create a list of schedules for a promoter
        /// </summary>
        /// <param name="scheduleList">This is the list of Schedules for a Promoter</param>
        /// <returns>return True if all the schedules have been created </returns>
        public bool CreatePromoterSchedule(IList<PromoterSchedule> scheduleList)
        {
            var result = this.scheduleRepository.CreatePromoterSchedule(scheduleList);

            if (!result)
            {
                throw new NotCreatedScheduleException();
            }

            return true;
        }

        /// <summary>
        /// Get a list of PromoterSchedule by promoterId
        /// </summary>
        /// <param name="promoterId">
        /// this is a id of a Promoter
        /// </param>
        /// <returns>
        /// Return a list of PromoterSchedule Models
        /// </returns>
        public List<PromoterSchedule> GetPromoterSchedule(int promoterId)
        {
            var promoterSchedule = this.promoterScheduleRepository.GetPromoterSchedule(promoterId);

            if (promoterSchedule == null)
            {
                throw new NullListPromoterScheduleException();
            }

            return promoterSchedule;
        }

        /// <summary>
        /// Set the repository instance of a promoterScheduleRepository used for this class
        /// </summary>
        /// <param name="promoterScheduleRepository">
        /// An instance of IPromoterScheduleRepository to be set
        /// </param>
        public void SetPromoterScheduleRepository(IPromoterScheduleRepository promoterScheduleRepository)
        {
            this.promoterScheduleRepository = promoterScheduleRepository;
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
        /// Set the repository instance of a category used for this class
        /// </summary>
        /// <param name="categoryRepository">
        /// An instance of ICategoryRepository to be set
        /// </param>
        public void SetCategoryRepository(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
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

        /// <summary>
        /// Set the repository instance of a image used for this class
        /// </summary>
        /// <param name="imageRepository">
        /// An instance of IImageRepository to be set
        /// </param>
        public void SetImageRepository(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }

        /// <summary>
        /// Set the repository instance of a store used for this class
        /// </summary>
        /// <param name="storeRepository">
        /// An instance of IStoreRepository to be set
        /// </param>
        public void SetStoreRepository(IStoreRepository storeRepository)
        {
            this.storeRepository = storeRepository;
        }

        /// <summary>
        /// Set the repository instance of a promoterTag used for this class
        /// </summary>
        /// <param name="promoterTagRepository">
        /// An instance of IPromoterTagRepository to be set
        /// </param>
        public void SetPromoterTagRepository(IPromoterTagRepository promoterTagRepository)
        {
            this.promoterTagRepository = promoterTagRepository;
        }

        /// <summary>
        /// Set the repository instance of a schedule used for this class
        /// </summary>
        /// <param name="scheduleRepository">
        /// An instance of IScheduleRepository to be set
        /// </param>
        public void SetScheduleRepository(IScheduleRepository scheduleRepository)
        {
            this.scheduleRepository = scheduleRepository;
        }
    }
}

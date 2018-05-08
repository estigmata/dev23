// <copyright file="ServiceImage.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.Services
{
    using JalaFoundation.Advantage.BusinessLogic.Interfaces;
    using JalaFoundation.Advantage.DataAccess;
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.DataAccess.Repositories;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The ServiceImage class extends from SingletonBase Class and IForm interface
    /// Implement methods to interact with the DataAccess Project
    /// </summary>
    public class ServiceImage : SingletonBase<ServiceImage>, IImage
    {
        /// <summary>
        /// An instance of IRepository
        /// </summary>
        private IImageRepository imageRepository;

        /// <summary>
        /// Prevents a default instance of the <see cref="ServiceImage"/> class from being created.
        /// </summary>
        private ServiceImage() : base()
        {
            this.imageRepository = RepositoryFactory.GetImageRepository();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceImage"/> class.
        /// </summary>
        /// <param name="imageRepository">
        /// Receives the instance of IImageRepository
        /// </param>
        private ServiceImage(IImageRepository imageRepository) : base()
        {
            this.imageRepository = imageRepository;
        }

        /// <summary>
        /// Send a object Image to Data Access Project
        /// </summary>
        /// <param name="image">
        /// The image is a string 
        /// </param>
        /// <returns>
        /// Return its Form Model  
        /// </returns>
        public Image SaveImage(string image)
        {
            var imageModels = new Image()
            {
                ImageSerialized = image
            };

            return this.imageRepository.Create(imageModels);
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
    }
}

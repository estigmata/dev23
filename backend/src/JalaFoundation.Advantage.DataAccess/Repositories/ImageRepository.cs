// <copyright file="ImageRepository.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Repositories
{
    using JalaFoundation.Advantage.DataAccess.Interfaces;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The ImageRepository class implements methods from IRepository
    /// </summary>
    public class ImageRepository : IRepository<Image>, IImageRepository
    {
        /// <summary>
        /// Save a Image in Database
        /// </summary>
        /// <param name="model">
        /// model is the Image Model to be saved
        /// </param>
        /// <returns>
        /// Returns a Image Object
        /// </returns>
        public Image Create(Image model)
        {
            using (var context = new AdvantageContext())
            {
                var imageSaved = context.Images.Add(model);
                context.SaveChanges();
                return imageSaved;
            }
        }

        /// <summary>
        /// Update a Model of a Image
        /// </summary>
        /// <param name="model">
        /// The model Image that be updated
        /// </param>
        /// <returns>
        /// Returns a model Image updated
        /// </returns>
        public Image Update(Image model)
        {
            using (var context = new AdvantageContext())
            {
                var updateModel = context.Images.Find(model.Id);
                updateModel.ImageSerialized = model.ImageSerialized;
                context.SaveChanges();
                return updateModel;
            }
        }

        /// <summary>
        /// Return an Image from the database using his specific id as parameter
        /// </summary>
        /// <param name="id">
        /// The id represents the id property from the searched Image
        /// </param>
        /// <returns>return an Image with the specified id</returns>
        public Image Get(int id)
        {
            using (var context = new AdvantageContext())
            {
                return context.Images.Find(id);
            }
        }
    }
}

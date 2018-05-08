// <copyright file="IImage.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Interfaces
{
    using Models;

    /// <summary>
    /// The IImage interface define the methods necessary to interact with the Data Access Project
    /// </summary>
    public interface IImage
    {
        /// <summary>
        /// Send a object Image to Data Access Project
        /// </summary>
        /// <param name="image">
        /// The image is a string 
        /// </param>
        /// <returns>
        /// Return its Form Model  
        /// </returns>
        Image SaveImage(string image);
    }
}

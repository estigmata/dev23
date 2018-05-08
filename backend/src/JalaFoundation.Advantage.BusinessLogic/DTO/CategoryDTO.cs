// <copyright file="CategoryDTO.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.DTO
{
    /// <summary>
    /// This class use the Category and add a NewBenefits field.
    /// </summary>
    public class CategoryDTO
    {
        /// <summary>
        /// Gets or sets the Id of the category
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Gets or sets the Name of the category
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or sets the Icon of the category
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the quantity of new benefits of a category, this value will be calculated
        /// </summary>
        public int NewBenefitsQuantity { get; set; }
    }
}

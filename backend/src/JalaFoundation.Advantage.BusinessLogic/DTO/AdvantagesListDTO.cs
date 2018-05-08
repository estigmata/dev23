// <copyright file="AdvantagesListDTO.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.DTO
{
    using System.Collections.Generic;

    /// <summary>
    /// This class is used to model information from benefit, promotion and image in a single class.
    /// </summary>
    public class AdvantagesListDTO
    {
        /// <summary>
        /// Gets or sets the Total number of items
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Gets or sets the list of advantages
        /// </summary>
        public List<BenefitDTO> Data { get; set; }
    }
}

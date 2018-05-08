// <copyright file="PromoterDTO.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.DTO
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class is used to model specific information from the class Promoter in order to be returned from the web api
    /// </summary>
    public class PromoterDTO
    {
        /// <summary>
        /// Gets or sets the Name of the PromoterDTO object
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Logo of the PromoterDTO object
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// Gets or sets a tuple indicating whether a promoter is open or closed
        /// </summary>
        public Tuple<bool, string> IsOpen { get; set; }

        /// <summary>
        /// Gets or sets a List of tags of the Promoter
        /// </summary>
        public virtual List<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the category of a promoter
        /// </summary>
        public string Category { get; set; }
    }
}
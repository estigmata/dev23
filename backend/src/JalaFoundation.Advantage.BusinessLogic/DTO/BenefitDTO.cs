// <copyright file="BenefitDTO.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.BusinessLogic.DTO
{
    /// <summary>
    /// This class is used to model specific information from the class Benefit in order to be returned from the web api
    /// </summary>
    public class BenefitDTO
    {
        /// <summary>
        /// Gets or sets the Id of the benefit
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the Name of the benefit
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Description of a benefit
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Main Text of a benefit
        /// </summary>
        public string MainText { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a benefit is active or inactive
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a benefit is new
        /// </summary>
        public bool IsNew { get; set; }

        /// <summary>
        /// Gets or sets the promoter related to a benefit
        /// </summary>
        public PromoterDTO Promoter { get; set; }
    }
}

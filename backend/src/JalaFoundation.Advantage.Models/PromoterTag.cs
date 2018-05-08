// <copyright file="PromoterTag.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The PromoterTag class contains the information of relationship between a promoter class and tag class 
    /// </summary>
    public class PromoterTag
    {
        [Key]

        /// <summary>
        /// Gets or sets the Id of the PromoterTag
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the PromoterID of the PromoterTag
        /// </summary>
        [ForeignKey("Promoter")]
        public int PromoterID { get; set; }

        /// <summary>
        /// Gets or sets the Promoter of a PromoterTag
        /// </summary>
        public virtual Promoter Promoter { get; set; }

        /// <summary>
        /// Gets or sets the TagID of the PromoterTag
        /// </summary>
        [ForeignKey("Tag")]
        public int TagID { get; set; }

        /// <summary>
        /// Gets or sets the Tag of a PromoterTag
        /// </summary>
        public virtual Tag Tag { get; set; }
    }
}

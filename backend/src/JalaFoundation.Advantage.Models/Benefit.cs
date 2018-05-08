// <copyright file="Benefit.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The Benefit class contains the information about a Benefit as the Id, Name, Description, Status, Banner
    /// </summary>
    public class Benefit
    {
        /// <summary>
        /// Gets or sets the Id of the Benefit
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the Name of the Benefit
        /// </summary>
        [Required]
        [MaxLength(150, ErrorMessage = "Name can't have more than 150 letters")]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Description of the Benefit
        /// </summary>
        [Required]
        [MaxLength(300, ErrorMessage = "Description can't have more than 300 letters")]
        [Column(TypeName = "varchar")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Main Text of the Benefit
        /// </summary>
        [Required]
        [MaxLength(90, ErrorMessage = "Main Text can't have more than 90 letters")]
        [Column(TypeName = "varchar")]
        public string MainText { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Status of the Benefit
        /// </summary>
        [Required]
        [Column(TypeName = "bit")]
        public bool Status { get; set; }

        /// <summary>
        /// Gets or sets the respective Banner Id of the Benefit
        /// </summary>
        public long BannerID { get; set; }

        [ForeignKey("BannerID")]

        /// <summary>
        /// Gets or sets the View of an Benefit
        /// </summary>
        public virtual Banner Banner { get; set; }

        /// <summary>
        /// Gets or sets the promoterId attribute
        /// </summary>
        [ForeignKey("Promoter")]
        public int PromoterId { get; set; }

        /// <summary>
        /// Gets or sets the Benefit to which the benefit belongs
        /// </summary>
        public virtual Promoter Promoter { get; set; }

        /// <summary>
        /// Gets or sets the creation date of the Benefit 
        /// </summary>
        [Required]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or sets of days quantity that Benefit will be available
        /// </summary>
        public int? Duration { get; set; }
    }
}

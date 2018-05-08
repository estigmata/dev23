// <copyright file="Banner.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The Banner class contains the information about a Banner as the Id, Author, CreationDate, Model
    /// </summary>
    public class Banner
    {
        /// <summary>
        /// Gets or sets the Id of the Banner
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the Model of the Banner, the Model is the representation in JSON Format
        /// </summary>
        [Required]
        [Column(TypeName = "text")]
        public string Model { get; set; }
    }
}

// <copyright file="Category.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Category class contains information about the promoter's category
    /// </summary>
    public class Category
    {
        [Key]

        /// <summary>
        /// Gets or sets the Id of the Category
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Name of the Category
        /// </summary>
        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Icon of the Category
        /// </summary>
        [Column(TypeName = "varchar(MAX)")]
        public string Icon { get; set; }
    }
}
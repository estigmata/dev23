// <copyright file="Contact.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Contact class contains information about the promoter's contact
    /// </summary>
    public class Contact
    {
        [Key]

        /// <summary>
        /// Gets or sets the Id of the Contact
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Name of the Contact
        /// </summary>
        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Phone of the Contact
        /// </summary>
        public int? Phone { get; set; }

        /// <summary>
        /// Gets or sets the Email of the Contact
        /// </summary>
        [MaxLength(320)]
        [Column(TypeName = "varchar")]
        public string Email { get; set; }
    }
}
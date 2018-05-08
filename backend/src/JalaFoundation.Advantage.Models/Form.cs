// <copyright file="Form.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The Form class contains the information about a Form as the author, name of form, date of creation, and the model of Form
    /// </summary>
    public class Form
    {
        /// <summary>
        /// Gets or sets the Id of the Form
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Author of the Form
        /// </summary>
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the Name of the Form
        /// </summary>
        [Required]
        [MaxLength(300)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Creation Date of the Form
        /// </summary>
        [Required]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or sets the Model of the Form, the Model is the representation in JSON Format
        /// </summary>
        [Required]
        [Column(TypeName = "text")]
        public string Model { get; set; }
    }
}

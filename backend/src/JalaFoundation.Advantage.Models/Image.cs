// <copyright file="Image.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The Image class contains the information about a Image as the identificator, and serialized of Image
    /// </summary>
    public class Image
    {
        /// <summary>
        /// Gets or sets the Id of the Image
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the serialized of the Image, the serialized is the representation in string Format
        /// </summary>
        [Required]
        [Column(TypeName = "text")]
        public string ImageSerialized { get; set; }
    }
}

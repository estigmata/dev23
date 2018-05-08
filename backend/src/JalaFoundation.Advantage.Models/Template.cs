// <copyright file="Template.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Newtonsoft.Json;

    /// <summary>
    /// The Template class contains the information about a Template
    /// </summary>
    public class Template
    {
        /// <summary>
        /// Gets or sets the Id of the Template 
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Name of the Template
        /// </summary>
        [Required]
        [MaxLength(150, ErrorMessage = "Name can't have more than 150 letters")]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the relationship one to more with TemplateSchedule model
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual ICollection<TemplateSchedule> TemplateSchedule { get; set; }
    }
}

// <copyright file="Role.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The role class contains the information about which role have the users and also the url that they have to be redirected
    /// </summary> 
    public class Role
    {
        [Key]

        /// <summary>
        /// Gets or sets the Id of the Role
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the Name of the Role
        /// </summary>
        [MaxLength(30)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Url of the Role
        /// </summary>
        [MaxLength(2083)]
        [Column(TypeName = "nvarchar")]
        public string Url { get; set; }
    }
}

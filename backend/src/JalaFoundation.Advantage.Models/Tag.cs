// <copyright file="Tag.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The Tag class contains the information of the product or service offered by one or more promoters
    /// </summary>
    public class Tag
    {
        [Key]

        /// <summary>
        /// Gets or sets the Id of the Tag
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Name of the Tag
        /// </summary>
        [MaxLength(30)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the relationship many to many with Promoter model
        /// </summary>
        public virtual ICollection<PromoterTag> PromoterTag { get; set; }
    }
}

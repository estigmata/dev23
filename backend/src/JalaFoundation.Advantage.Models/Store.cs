// <copyright file="Store.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The Store class contains the information about Store
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Gets or sets the Id of the Store
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Name of the Store
        /// </summary>
        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Phone of the Store
        /// </summary>
        public int? Phone { get; set; }

        /// <summary>
        /// Gets or sets the Address of the Store
        /// </summary>
        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the PromoterId of the relation with Promoter model
        /// </summary>
        public int PromoterID { get; set; }

        /// <summary>
        /// Gets or sets the Relationship with Promoter model
        /// </summary>
        [ForeignKey("PromoterID")]
        public virtual Promoter Promoter { get; set; }
    }
}

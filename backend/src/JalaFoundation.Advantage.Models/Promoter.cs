// <copyright file="Promoter.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The Promoter class contains the information about promoter, the user, the category, image and contact that It has
    /// </summary>
    public class Promoter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Promoter"/> class
        /// </summary>
        public Promoter()
        {
            this.Benefits = new List<Benefit>();
            this.Stores = new List<Store>();
        }
        
        /// <summary>
        /// Gets or sets the Id of the Promoter
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Name of the Promoter
        /// </summary>
        [MaxLength(200)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the respective Image Id of the Promoter
        /// </summary>
        public int ImageID { get; set; }
        
        /// <summary>
        /// Gets or sets the Image of a Promoter
        /// </summary>
        [ForeignKey("ImageID")]
        public virtual Image Image { get; set; }

        /// <summary>
        /// Gets or sets the respective Category Id of the Promoter
        /// </summary>
        public int CategoryID { get; set; }
        
        /// <summary>
        /// Gets or sets the Category of a Promoter
        /// </summary>
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        /// <summary>
        /// Gets or sets the respective Contact Id of the Promoter
        /// </summary>
        public int ContactID { get; set; }
        
        /// <summary>
        /// Gets or sets the Contact of a Promoter
        /// </summary>
        [ForeignKey("ContactID")]
        public virtual Contact Contact { get; set; }

        /// <summary>
        /// Gets or sets the respective User Id of the Promoter
        /// </summary>
        public long UserID { get; set; }
        
        /// <summary>
        /// Gets or sets the User of a Promoter
        /// </summary>
        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        /// <summary>
        /// Gets or sets the collection of benefits of a promoter
        /// </summary>
        public virtual ICollection<Benefit> Benefits { get; set; }

        /// <summary>
        /// Gets or sets the relationship one to more with Stores model
        /// </summary>
        public virtual ICollection<Store> Stores { get; set; }

        /// <summary>
        /// Gets or sets the relationship many to many with Tag model
        /// </summary>
        public virtual ICollection<PromoterTag> PromoterTag { get; set; }

        /// <summary>
        /// Gets or sets the relationship one to more with PromoterSchedule model
        /// </summary>
        public virtual ICollection<PromoterSchedule> PromoterSchedule { get; set; }
    }
}
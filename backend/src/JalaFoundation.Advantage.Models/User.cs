// <copyright file="User.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The User class contains the information about user and the role that It has
    /// </summary>
    public class User
    {
        [Key]

        /// <summary>
        /// Gets or sets the Id of the User
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the Email of the User
        /// </summary>
        [MaxLength(320)]
        [Column(TypeName = "varchar")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the Password of the User
        /// </summary>
        [MaxLength(30)]
        [Column(TypeName = "nvarchar")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the the respective Role Id of the User
        /// </summary>
        public long RoleId { get; set; }

        [ForeignKey("RoleId")]

        /// <summary>
        /// Gets or sets the Role of an User
        /// </summary>
        public virtual Role Role { get; set; }
    }
}

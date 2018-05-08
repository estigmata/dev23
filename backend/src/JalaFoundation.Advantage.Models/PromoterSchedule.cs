// <copyright file="PromoterSchedule.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The PromoterSchedule class contains the information about the relation between a template and a Schedule
    /// </summary>
    public class PromoterSchedule
    {
        /// <summary>
        /// Gets or sets the Id of the PromoterSchedule
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the PromoterId relation attribute
        /// </summary>
        [ForeignKey("Promoter")]
        public int PromoterId { get; set; }

        /// <summary>
        /// Gets or sets the ScheduleId relation attribute
        /// </summary>
        [ForeignKey("Schedule")]
        public int ScheduleId { get; set; }

        /// <summary>
        /// Gets or sets the Schedule to which the TemplateSchedule belongs
        /// </summary>
        public virtual Schedule Schedule { get; set; }

        /// <summary>
        /// Gets or sets the Promoter to which the TemplateSchedule belongs
        /// </summary>
        public virtual Promoter Promoter { get; set; }
    }
}

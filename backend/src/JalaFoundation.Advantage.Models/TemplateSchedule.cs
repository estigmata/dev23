// <copyright file="TemplateSchedule.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Newtonsoft.Json;

    /// <summary>
    /// The TemplateSchedule class contains the information about the relation between a Promoter and a Schedule
    /// </summary>
    public class TemplateSchedule
    {
        /// <summary>
        /// Gets or sets the Id of the TemplateSchedule
        /// </summary>
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the TemplateId relation attribute
        /// </summary>
        [ForeignKey("Template")]
        [JsonIgnore]
        public int TemplateId { get; set; }

        /// <summary>
        /// Gets or sets the ScheduleId relation attribute
        /// </summary>
        [ForeignKey("Schedule")]
        [JsonIgnore]
        public int ScheduleId { get; set; }

        /// <summary>
        /// Gets or sets the Schedule to which the TemplateSchedule belongs
        /// </summary>
        public virtual Schedule Schedule { get; set; }

        /// <summary>
        /// Gets or sets the Template to which the TemplateSchedule belongs
        /// </summary>
        public virtual Template Template { get; set; }
    }
}

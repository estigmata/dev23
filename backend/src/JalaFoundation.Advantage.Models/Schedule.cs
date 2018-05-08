// <copyright file="Schedule.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Newtonsoft.Json;

    /// <summary>
    /// The Schedule class contains the information about one Schedule
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// Gets or sets the Id of the Schedule
        /// </summary>
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Day of the Schedule
        /// </summary>
        [Required]
        [Range(1, 7, ErrorMessage = "The day must be a number from 1 to 7")]
        public DayOfWeek Day { get; set; }

        /// <summary>
        /// Gets or sets the start time of the Schedule
        /// </summary>
        [Required]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "time")]
        public TimeSpan From { get; set; }

        /// <summary>
        /// Gets or sets the end time of the Schedule
        /// </summary>
        [Required]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "time")]
        public TimeSpan To { get; set; }
    }
}

// <copyright file="AdvantageContext.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.DataAccess
{
    using System.Data.Entity;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The AdvantageContext class can be used to query from a database and group together changes that will then be written back to the store as a unit
    /// </summary>
    public class AdvantageContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvantageContext"/> class.
        /// If you wish to target a different database and/or database provider, modify the 'AdvantageContext' 
        /// connection string in the application configuration file.
        /// </summary>
        public AdvantageContext()
            : base("name=AdvantageContext")
        {
        }

        /// <summary>
        /// Gets or sets the DbSet for Role class
        /// </summary>
        public DbSet<Role> Roles { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for User class
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for Form class
        /// </summary>
        public DbSet<Form> Forms { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for Image class
        /// </summary>
        public DbSet<Image> Images { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for Promoter class
        /// </summary>
        public DbSet<Promoter> Promoters { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for Category class
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for Contact class
        /// </summary>
        public DbSet<Contact> Contacts { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for Benefit class
        /// </summary>
        public DbSet<Benefit> Benefits { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for Banner class
        /// </summary>
        public DbSet<Banner> Banners { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for Store class
        /// </summary>
        public DbSet<Store> Stores { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for Tag class
        /// </summary>
        public DbSet<Tag> Tags { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for PromoterTag class
        /// </summary>
        public DbSet<PromoterTag> PromoterTags { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for Templates class
        /// </summary>
        public DbSet<Template> Templates { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for Schedules class
        /// </summary>
        public DbSet<Schedule> Schedules { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for PromoterSchedules class
        /// </summary>
        public DbSet<PromoterSchedule> PromoterSchedules { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for TemplateSchedules class
        /// </summary>
        public DbSet<TemplateSchedule> TemplateSchedules { get; set; }
    }
}
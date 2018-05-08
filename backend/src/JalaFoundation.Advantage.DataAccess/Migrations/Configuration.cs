// <copyright file="Configuration.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.DataAccess.Migrations
{
    using System;
    using System.Configuration;
    using System.Data.Entity.Migrations;
    using JalaFoundation.Advantage.Models;

    /// <summary>
    /// The Configuration class establish configuration relating to the use of migrations for a given model.
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<JalaFoundation.Advantage.DataAccess.AdvantageContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration"/> class.
        /// </summary>
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
        }

        /// <summary>
        /// Seed method is to enable you to insert or update test data after Code First creates or updates the database
        /// </summary>
        /// <param name="context">The context of the database Model</param>
        protected override void Seed(JalaFoundation.Advantage.DataAccess.AdvantageContext context)
        {
            var url  = ConfigurationManager.AppSettings.Get("path");

            context.Roles.AddOrUpdate(
                x => x.Id,
                new Role() { Id = 1, Name = "Coordinator", Url = $"{url}/organizers" },
                new Role() { Id = 2, Name = "Promoter", Url = $"{url}/sellers" },
                new Role() { Id = 3, Name = "Employee", Url = $"{url}/promotions" });
        }
    }
}

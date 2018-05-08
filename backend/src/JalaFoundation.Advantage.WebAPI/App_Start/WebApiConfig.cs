// <copyright file="WebApiConfig.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>
namespace JalaFoundation.Advantage.WebAPI
{
    using System.Web.Http;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    /// <summary>
    /// The class to set the configurations to the Web Api.
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Register the configuration for the Api.
        /// </summary>
        /// <param name="config">The object to configure</param>
        public static void Register(HttpConfiguration config)
        {
            var settings = GlobalConfiguration.Configuration?.Formatters?.JsonFormatter?.SerializerSettings;

            if (settings != null)
            {
                settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                settings.Formatting = Formatting.Indented;
            }
           
            config.EnableCors();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/v1/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
        }
    }
}

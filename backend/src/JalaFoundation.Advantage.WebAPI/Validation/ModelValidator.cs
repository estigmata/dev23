// <copyright file="ModelValidator.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.WebAPI.Validation
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Reflection;

    /// <summary>
    /// The ModelValidator static class implement static methods to Validate the attributes of a model using reflection
    /// </summary>
    public static class ModelValidator
    {
        /// <summary>
        /// Validate a model
        /// </summary>
        /// <param name="model">
        /// The model to be validate
        /// </param>
        /// <returns> 
        /// Returns a IEnumerable with all the errors on the model
        /// </returns>
        public static IEnumerable<string> Validate(object model)
        {
            Type type = model.GetType();
            PropertyInfo[] properties = type.GetProperties();
            Type attrType = typeof(ValidationAttribute);

            foreach (var property in properties)
            {
                object[] customAttributes = property.GetCustomAttributes(attrType, inherit: true);

                foreach (var customAttribute in customAttributes)
                {
                    var validationAttribute = (ValidationAttribute)customAttribute;

                    bool isValid = validationAttribute.IsValid(property.GetValue(model, BindingFlags.GetProperty, null, null, null));

                    if (!isValid)
                    {
                        yield return validationAttribute.ErrorMessage;
                    }
                }
            }
        }
    }
}
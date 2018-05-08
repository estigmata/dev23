// <copyright file="SingletonBase.cs" company="Jala Foundation">
//     Copyright (c) Jala Foundation. All rights reserved.
// </copyright>

namespace JalaFoundation.Advantage.BusinessLogic.Services
{
    using System;
    using System.Reflection;

    /// <summary>
    /// The RepositoryFactory class implements a Generic Singleton Pattern
    /// </summary>
    /// <typeparam name="T">
    /// T represents a class
    /// </typeparam>
    public class SingletonBase<T> where T : SingletonBase<T>
    {
        /// <summary>
        /// Instance of an object  who will be used at a lock statement
        /// </summary>
        private static object lockingObject = new object();

        /// <summary>
        /// Instance of a Class who will be used to create the instance of the T class
        /// </summary>
        private static T singletonObject;

        /// <summary>
        /// Initializes a new instance of the <see cref="SingletonBase{T}"/> class.
        /// </summary>
        protected SingletonBase()
        {
        }

        /// <summary>
        /// Gets a new or a created instance of the {T} class
        /// </summary>
        /// <returns>
        /// Returns the instance of the {T} class
        /// </returns>
        public static T GetInstance()
        {
            if (singletonObject == null)
            {
                lock (lockingObject)
                {
                    if (singletonObject == null)
                    {
                        singletonObject = (T)Activator.CreateInstance(typeof(T), true);
                    }
                }
            }

            return singletonObject;
        }

        /// <summary>
        /// Gets a new or a created instance of the {T} class
        /// </summary>
        /// <param name="args">
        /// Recieve the arguments for the contructor of the {T} class
        /// </param>
        /// <returns>
        /// Returns the instance of the {T} class
        /// </returns>
        public static T GetInstance(params object[] args)
        {
            if (singletonObject == null)
            {
                lock (lockingObject)
                {
                    if (singletonObject == null)
                    {
                        singletonObject = (T)Activator.CreateInstance(typeof(T), BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public, null, args, null);                    
                    }
                }
            }

            return singletonObject;
        }
    }
}
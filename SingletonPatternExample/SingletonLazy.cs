//------------------------------------------------------------------------
// <copyright file="SingletonLazy.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace SingletonPatternExample
{
    using System;

    public class SingletonLazy
    {
        /// <summary>
        /// The lazy
        /// </summary>
        private static readonly Lazy<SingletonLazy> lazy = new Lazy<SingletonLazy>(() => new SingletonLazy());

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static SingletonLazy Instance { get { return lazy.Value; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingletonLazy"/> class.
        /// </summary>
        protected SingletonLazy() { }
    }
}

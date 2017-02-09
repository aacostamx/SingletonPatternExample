//------------------------------------------------------------------------
// <copyright file="Singleton.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace SingletonPatternExample
{
    public class Singleton
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static Singleton instance;

        /// <summary>
        /// Initializes a new instance of the <see cref="Singleton"/> class.
        /// </summary>
        protected Singleton() { }

        /// <summary>
        /// Instances this instance.
        /// </summary>
        /// <returns></returns>
        public static Singleton Instance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}

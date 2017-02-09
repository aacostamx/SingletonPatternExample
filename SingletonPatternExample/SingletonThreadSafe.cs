//------------------------------------------------------------------------
// <copyright file="SingletonThreadSafe.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace SingletonPatternExample
{
    public class SingletonThreadSafe
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static SingletonThreadSafe instance = null;

        /// <summary>
        /// The synchronize root
        /// </summary>
        private static readonly object syncRoot = new object();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingletonThreadSafe"/> class.
        /// </summary>
        protected SingletonThreadSafe() { }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static SingletonThreadSafe Instance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new SingletonThreadSafe();
                    }
                }

            }
            return instance;
        }

    }
}

//------------------------------------------------------------------------
// <copyright file="Program.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace SingletonPatternExample
{
    using System;

    public class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            SingletonThreadSafe s3 = SingletonThreadSafe.Instance();
            SingletonThreadSafe s4 = SingletonThreadSafe.Instance();

            SingletonLazy s5 = SingletonLazy.Instance;
            SingletonLazy s6 = SingletonLazy.Instance;


            if (s1 == s2)
            {
                Console.WriteLine("Objects Singleton are the same instance");
            }

            if (s3 == s4)
            {
                Console.WriteLine("Objects SingletonThreadSafe are the same instance");
            }

            if (s5 == s6)
            {
                Console.WriteLine("Objects SingletonLazy are the same instance");
            }

            Console.ReadKey();
        }
    }
}

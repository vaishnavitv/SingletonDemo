using System;

namespace SingletonDemo
{
    public sealed class LazySingleton
    {
        //exploring Lazy<T> - thread safe
        private static Lazy<LazySingleton> instance = new Lazy<LazySingleton>(() => new LazySingleton());

        static int counter = 10;

        // Prevent instantiation outside
        private LazySingleton()
        {
            counter++;
        }

        static LazySingleton() { } // Make sure it's truly lazy

        public static LazySingleton GetInstance = instance.Value;
    }
}

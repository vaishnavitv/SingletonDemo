using System;

namespace SingletonDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Singleton singleton = new Singleton();

            Singleton singleton = Singleton.GetInstance;
            LazySingleton lazySingleton = LazySingleton.GetInstance;
            Lazy<Foo> f = new Lazy<Foo>(
                () => new Foo()
            );

            Console.WriteLine($" Foo Initialized Yet? {f.IsValueCreated}");
            Console.WriteLine($" ID : {(f.Value as Foo).ID}");
            Console.WriteLine($" Foo Initialized Yet? {f.IsValueCreated}");

            Console.ReadLine();
        }
    }
}

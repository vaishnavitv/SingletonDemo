using System;

namespace SingletonDemo
{
    class Foo
    {
       public int ID
        {
            get;
            set;
        }

        public Foo()
        {
            Console.WriteLine(" Foo called");
            ID = 1;
        }

        //get { if (foo == null) foo = new Foo(); return foo; } is not thread-safe, while Lazy<T> is thread-safe by default.

    }
}

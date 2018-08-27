namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static volatile Singleton instance;
        private static object syncRoot = new object();
        static int counter = 10;

        // Prevent instantiation outside
        private Singleton()
        {
            counter++;
        }
        
        public static Singleton GetInstance
        {
            get
            {
                if( instance == null)
                {
                    lock(syncRoot)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }

                return instance;
            }
        }
    }
}

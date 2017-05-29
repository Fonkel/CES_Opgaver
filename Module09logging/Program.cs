
using System;

namespace Module09logging
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            test1(5, 5);
            test2();
        }

        static void test1(int i, int x)
        {
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(3000);
        }

        static void test2()
        {
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception ex)
            {
                // mangler log
            }
        }
    }
}

using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul09Logging
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Trace("Her starter vi");
            logger.Debug("Kald af Test1");
            test1(5, 5);
            logger.Debug("Efter Test1");

            logger.Debug("Kald af Test2");
            test2();
            logger.Debug("Efter Test2");

            logger.Trace("Her slutter vi så");
        }

        static void test1(int i, int x)
        {
            logger.Trace("Nu er vi nede i test1, i = " + i + " x = " + x);
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(3000);
        }

        static void test2()
        {
            logger.Trace("Nu er vi nede i test2");

            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("Fejl!!!");
            }
            catch (Exception ex)
            {
                // mangler log
                logger.Error(ex);
            }

            logger.Trace("Nu er vi på vej ud af test2");

        }
    }
}

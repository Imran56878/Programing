using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerNet
{
    class Add
    {
        private static readonly log4net.ILog log= log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void add()
        {
            Console.Write("Enter two number's ");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("The sum is :"+(a+b));
            }
            
            catch (Exception e)
            {
                log.Error(e.Message );
            }
        }
    }
}

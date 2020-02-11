using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(Watch=true)]

namespace LoggerNet
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType );
        static void Main(string[] args)
        {
           // Add a = new Add();
            Add.add();
             Console.Write("Hello!");
             log.Error("This is error message ");
             log.Info("This is info message");
            log.Debug("This id debug message");
            log.Fatal("This is Fatal message");
             Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Manulife.ChengDu.DesignPattern.FactoryMethod.Interface;
using Manulife.ChengDu.DesignPattern.FactoryMethod.Factory;
using Manulife.ChengDu.DesignPattern.FactoryMethod.Product;

namespace Manulife.ChengDu.DesignPattern.FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ILoggerFactory LoggerFactory;
            ILogger Logger;

            bool CreateDBLogger = true;
            if (CreateDBLogger)
                LoggerFactory = new DatabaseLoggerFactory();
            else
                LoggerFactory = new FileLoggerFactory();

            Logger = LoggerFactory.CreateLogger();
            Logger.WriteLog();

            Console.ReadKey();
        }
        
    }
}

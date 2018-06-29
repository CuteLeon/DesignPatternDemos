using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manulife.ChengDu.DesignPattern.FactoryMethod.Interface;

namespace Manulife.ChengDu.DesignPattern.FactoryMethod.Product
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("文件日志记录...");
        }
    }
}

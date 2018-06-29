using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manulife.ChengDu.DesignPattern.FactoryMethod.Interface
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }
}

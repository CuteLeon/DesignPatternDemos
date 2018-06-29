using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manulife.ChengDu.DesignPattern.Singleton
{
    public sealed class LazyChild : LazyBase<LazyChild>
    {
        private LazyChild() { Console.WriteLine("创建" + this.GetType().ToString()); }
    }
}

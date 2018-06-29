using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manulife.ChengDu.DesignPattern.Singleton
{
    public sealed class HungryReadonly
    {
        public static HungryReadonly GetInstance { get; } = new HungryReadonly();
        //private static readonly HungryReadonly instance = new HungryReadonly();

        static HungryReadonly() { }

        private HungryReadonly() { Console.WriteLine("创建" + this.GetType().ToString()); }
    }
}

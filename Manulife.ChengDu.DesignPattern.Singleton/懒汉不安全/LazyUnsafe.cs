using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manulife.ChengDu.DesignPattern.Singleton
{
    public sealed class LazyUnsafe
    {
        private static LazyUnsafe instance;

        private LazyUnsafe() { Console.WriteLine("创建" + this.GetType().ToString()); }

        public static LazyUnsafe GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new LazyUnsafe();

                return instance;
            }
        }
    }
}

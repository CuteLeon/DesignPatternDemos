using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manulife.ChengDu.DesignPattern.Singleton
{
    public sealed class LazySafe
    {
        private volatile static LazySafe instance;
        private static readonly object lockobj = new object();

        private LazySafe() { Console.WriteLine("创建" + this.GetType().ToString()); }

        public static LazySafe GetInstance
        {
            get
            {
                if (instance == null)
                    lock(lockobj)
                        if (instance == null)
                            instance = new LazySafe();

                return instance;
            }
        }
    }
}

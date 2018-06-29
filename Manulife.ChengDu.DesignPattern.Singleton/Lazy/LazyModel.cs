using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manulife.ChengDu.DesignPattern.Singleton
{
    public sealed class LazyModel
    {
        private static readonly Lazy<LazyModel> instance = new Lazy<LazyModel>(() => new LazyModel() /* , 在这里设置线程安全 */ );

        private LazyModel() { Console.WriteLine("创建" + this.GetType().ToString()); }

        public static LazyModel GetInstance
        {
            get => instance.Value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Manulife.ChengDu.DesignPattern.Singleton
{
    public abstract class LazyBase<T>
    {
        //子类需要隐藏构造方法
        private static readonly Lazy<T> instance = new Lazy<T>(()=> {
            var ctors = typeof(T).GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            if (ctors.Count() == 0) throw new Exception(typeof(T).FullName + " 不包含构造函数");
            var ctor = ctors.SingleOrDefault(c => c.GetParameters().Count() == 0 && c.IsPrivate);
            if (ctor == null) throw new Exception("不包含无参私有构造方法");
            return (T)ctor.Invoke(null);
        });

        public static T GetInstance
        {
            get => instance.Value;
        }

    }
}

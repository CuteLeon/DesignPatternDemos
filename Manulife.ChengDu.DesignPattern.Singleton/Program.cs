using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manulife.ChengDu.DesignPattern.Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("\n懒汉不安全：创建实例 ");
            if (LazyUnsafe.GetInstance == LazyUnsafe.GetInstance)
                Console.WriteLine("相同");
            else
                Console.WriteLine("不相同");

            Console.Write("\n懒汉安全：创建实例 ");
            if (LazySafe.GetInstance == LazySafe.GetInstance)
                Console.WriteLine("相同");
            else
                Console.WriteLine("不相同");

            Console.Write("\n饿汉只读：创建实例 ");
            if (HungryReadonly.GetInstance == HungryReadonly.GetInstance)
                Console.WriteLine("相同");
            else
                Console.WriteLine("不相同");

            Console.Write("\nLazy：创建实例 ");
            if (LazyModel.GetInstance == LazyModel.GetInstance)
                Console.WriteLine("相同");
            else
                Console.WriteLine("不相同");

            Console.Write("\nLazy泛型：创建实例 ");
            if (LazyChild.GetInstance == LazyChild.GetInstance)
                Console.WriteLine("相同");
            else
                Console.WriteLine("不相同");

            Console.ReadKey();
        }
    }
}

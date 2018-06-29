using Manulife.ChengDu.DesignPattern.SimpleFactory.Interface;
using Manulife.ChengDu.DesignPattern.SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manulife.ChengDu.DesignPattern.SimpleFactory.Factory;

namespace Manulife.ChengDu.DesignPattern.SimpleFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IChartable chart = ChartFactory.GetChart("pie");
            chart.Display();
            Console.ReadKey();
        }

    }
}
